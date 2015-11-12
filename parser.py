__author__ = 'dustin.dunphy'

from bs4 import BeautifulSoup
import sys

class Tree(object):
    def __init__(self, data):
        self.data = data
        self.children = []
        self.parent = None
        self.column = False #Is it a KendoGrid Column?

    def add_child(self, obj):
        obj.parent = self.data
        self.children.append(obj)

    def print(self, level=0):
        print('Level {}: {}'.format(level, self.data))
        level += 1
        for child in self.children:
            child.print(level)


#Loops through each subsequent dict in regionPublicMethods
def PublicMethodsLoop(dictionary):
    strFormat = ''
    variableStr = ''
    for key, value in dictionary.items():
        strFormat = strFormat + '\n#region ' + key + '\n'
        if type(value) is dict:
            #It is a subsection so go into it
            print('This is a dict')
            strFormat = strFormat + PublicMethodsLoop(value)
        elif type(value) is list:
            #If it is a list then create entry for each variable
            print('This is a list')
            for item in value:
                if item[1] == 'by':
                    variableStr = """
/// <summary>
/// Gets the By for {publicMethod} in {section}
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any {publicMethod}</returns>
public static By {publicMethod}(string field)
{{
    By by = Elements.GetByValueWithField("{publicMethod}", {section}, field);
    return by;
}}
""".format(
                        publicMethod=item[0],
                        section=key
                    )
                elif item[1] == 'string':
                    variableStr = """
/// <summary>
/// Gets the string for the {publicMethod} in {section}
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns string for {publicMethod}</returns>
public static string {publicMethod}(string field)
{{
    return Elements.GetAttributeValue("string", "{publicMethod}", {section}, field);
}}
""".format(
                        publicMethod=item[0],
                        section=key
                    )
                elif item[1] == 'stringList':
                    variableStr = """
/// <summary>
/// Gets the string for the {publicMethod} in {section}
/// </summary>
/// <param name="fields">List of strings</param>
/// <returns>Returns the string value for {publicMethod}</returns>
public static string {publicMethod}(List<string> fields)
{{
    return Elements.GetAttributeValue("string", "{publicMethod}", {section}, fields);
}}
""".format(
                        publicMethod=item[0],
                        section=key
                    )
                elif item[1] == 'byList':
                    variableStr = """
/// <summary>
/// Gets the string for the {publicMethod} in {section}
/// </summary>
/// <param name="fields">List of strings</param>
/// <returns>Returns the string value for {publicMethod}</returns>
public static By {publicMethod}(List<string> fields)
{{
    By by = Elements.GetByValueWithField("{publicMethod}", {section}, fields);
    return by;
}}
""".format(
                        publicMethod=item[0],
                        section=key
                    )
                else:
                    raise SyntaxError("ERROR: item[0]: " + item[0] + " item[1]: " + item[1])
                strFormat = strFormat + variableStr
        else:
            raise SyntaxError("Value's type: " + type(value).__name__)
        strFormat = strFormat + '\n#endregion\n'
    return strFormat

#Loops through regionPublicMethods and formats string
def FormatPublicMethods():
    strFormat = '#region Public Methods\n'
    strFormat = strFormat + PublicMethodsLoop(regionPublicMethods)
    strFormat = strFormat + "\n#endregion"
    return strFormat

#Loops through each subsequent dict in regionPublicProperties
def PublicPropertiesLoop(dictionary):
    strFormat = ''
    variableStr = ''
    for key, value in dictionary.items():
        strFormat = strFormat + '\n#region ' + key + '\n'
        if type(value) is dict:
            #It is a subsection so go into it
            print('This is a dict')
            strFormat = strFormat + PublicPropertiesLoop(value)
        elif type(value) is list:
            #If it is a list then create entry for each variable
            print('This is a list')
            for item in value:
                if item[1] == 'by':
                    variableStr = """
/// <summary>
/// Gets the By for {publicProperty} {section} element
/// </summary>
public static By {publicProperty}
{{
    get
    {{
        return Elements.GetByValue("{publicProperty}", {section});
    }}
}}
""".format(
                        publicProperty=item[0],
                        section=key
                    )
                elif item[1] == 'string':
                    variableStr = """
/// <summary>
/// Gets the By for {publicProperty} {section} element
/// </summary>
public static string {publicProperty}
{{
    get
    {{
        return Elements.GetAttributeValue("string", "{publicProperty}", {section});
    }}
}}
""".format(
                        publicProperty=item[0],
                        section=key
                    )
                elif item[1] == 'column':
                    name = item[0]
                    field = item[2]
                    firstChar = name[0]
                    formattedName = name.replace(firstChar, '_' + firstChar.lower(), 1)
                    columnSection = 'Columns' + key
                    variableStr = """
/// <summary>
/// Gets the data-title and data-field information for {publicProperty}
/// </summary>
public static KendoGridColumnInfo {publicProperty}
{{
    get
    {{
        if ({privateVariable}.DataTitle == null)
        {{
            string dataTitle;
            string dataField;
            string field = "{field}";
            KendoPageElements.KendoGridColumnGetInfo(out dataTitle, out dataField, field, {section});
            {privateVariable}.Field = field;
            {privateVariable}.DataField = dataField;
            {privateVariable}.DataTitle = dataTitle;
        }}

        return {privateVariable};
    }}
}}
""".format(
                        publicProperty=name,
                        privateVariable=formattedName,
                        section=columnSection,
                        field=field
                    )
                strFormat = strFormat + variableStr
        else:
            print("Value's type: " + type(value).__name__)
        strFormat = strFormat + '\n#endregion\n'
    return strFormat

def FormatPublicProperties():
    strFormat = '#region Public Properties\n'
    strFormat = strFormat + PublicPropertiesLoop(regionPublicProperties)
    strFormat = strFormat + "\n#endregion"
    return strFormat

def PrivatePropertyLoop(tree):
    strFormat = ''
    for child in tree.children:
        childName = child.data
        firstChar = childName[0]
        formattedName = childName.replace(firstChar, '_' + firstChar.lower(), 1)

        if not child.column:
            variableStr = '''
/// <summary>
/// Gets the {propertyName} Elements from {parentName}
/// </summary>
private static IEnumerable<XElement> {propertyName}
{{
    get
    {{
        if ({privateVariable} == null)
        {{
            {privateVariable} = from d in {parentName}.Descendants("{propertyName}")
                                    select d;
        }}

        return {privateVariable};
    }}
}}
'''.format(
                propertyName=childName,
                parentName=child.parent,
                privateVariable=formattedName
            )
        else:
            variableStr = '''
/// <summary>
/// Gets the {propertyName} Elements from {parentName}
/// </summary>
private static IEnumerable<XElement> {propertyName}
{{
    get
    {{
        if ({privateVariable} == null)
        {{
            {privateVariable} = from d in {parentName}.Descendants("Column")
                                    select d;
        }}

        return {privateVariable};
    }}
}}
'''.format(
                propertyName=childName,
                parentName=child.parent,
                privateVariable=formattedName
            )
        strFormat = strFormat + variableStr

        if len(child.children) > 0:
            strFormat = strFormat + PrivatePropertyLoop(child)
    return strFormat

#Loops through regionPrivateProperties and formats string
def FormatPrivateProperties():
    strFormat = '#region Private Properties\n'
    name = regionPrivateProperties.data
    firstChar = name[0]
    formattedName = name.replace(firstChar, '_' + firstChar.lower(), 1)

    variableStr = '''
/// <summary>
/// Gets the {propertyName} Elements from xml
/// </summary>
private static IEnumerable<XElement> {propertyName}
{{
    get
    {{
        if ({privateVariable} == null)
        {{
            {privateVariable} = from d in GlobalValues.Elements.Root.Descendants("{propertyName}")
                                    select d;
        }}

        return {privateVariable};
    }}
}}
'''.format(
        propertyName=name,
        privateVariable=formattedName
    )

    strFormat = strFormat + variableStr

    strFormat = strFormat + PrivatePropertyLoop(regionPrivateProperties)
    strFormat = strFormat + "\n#endregion"
    return strFormat

#Loops through each subsequent dict in regionPrivateVariables
def PrivateVariableLoop(strFormat, dict):
    for key, value in dict.items():
        strFormat = strFormat + '#region ' + key + '\n'
        if type(value) is dict:
            #It is a subsection so go into it
            print('This is a dict')
            strFormat = PrivateVariableLoop(strFormat, value)
        elif type(value) is list:
            #If it is a list then create entry for each variable
            print('This is a list')
            for item in value:
                variableStr = """
/// <summary>
/// Contains All %s Elements from xml file
/// </summary>
private static IEnumerable<XElement> %s = null;
""" % (item.replace(item[0], '', 1), item)
                strFormat = strFormat + variableStr
        strFormat = strFormat + '\n#endregion\n\n'
    return strFormat

#Loops through regionPrivateVariables and formats string
def FormatPrivateVariables():
    strFormat = '#region Private Variables\n\n'

    for key, value in regionPrivateVariables.items():
        strFormat = strFormat + '#region ' + key + '\n'
        if type(value) is dict:
            #It is a subsection so go into it
            print('This is a dict')
            strFormat = PrivateVariableLoop(strFormat, value)
        elif type(value) is list:
            #If it is a list then create entry for each variable
            print('This is a list')
            if key == 'XElements':
                for item in value:
                    variableStr = """
    /// <summary>
    /// Contains All %s Elements from xml file
    /// </summary>
    private static IEnumerable<XElement> %s = null;
    """ % (item.replace(item[0], '', 1), item)
                    strFormat = strFormat + variableStr
            else:
                for item in value:
                    variableStr = """
    /// <summary>
    /// Contains the data-field and data-title info for {privateVariable} column
    /// </summary>
    private static KendoGridColumnInfo {privateVariable} = new KendoGridColumnInfo();
    """.format(
                        privateVariable=item
                    )
                    strFormat = strFormat + variableStr
        strFormat = strFormat + '\n#endregion\n\n'

    strFormat = strFormat + "#endregion"
    return strFormat

def ParseSection(section):
    # For each section, starting with the [Page] section will loop and map out everything
    print('------------------')
    name = section.name
    print(name)

    # Private Variables -> XElements variable names are in format _[Page Name (first letter lowercase)]
    firstChar = name[0]
    prName = name.replace(firstChar, '_' + firstChar.lower(), 1)
    print(prName)
    regionPrivateVariables['XElements'].append(prName)

    #Private Properties -> XElements properties are in format [Section Name]
    #regionPrivateProperties['XElements'].append(name)
    privatePropertyTree = Tree(name)
    print(regionPrivateVariables)

    #regionPublicProperties
    dictPublicProperty = {}
    #regionPublicMethods
    dictPublicMethod = {}

    isDict = True

    #Loops through each child of Section node
    for child in section.children:
        #Disregard children that only have newline character
        if child != '\n':
            #Extracts By information
            if child.has_attr('by'):
                #if not name in dictPublicProperty:
                 #   dictPublicProperty = []
                 #   dictPublicMethod = []
                if isDict:
                    isDict = False
                    dictPublicProperty = []
                    dictPublicMethod = []
                byValue = child['by']
                print(child.name, 'By =', byValue, ':', byValue, '=', child[byValue])
                if '####' in child[byValue]:
                    print(child.name, 'is a Public Method')
                    length = child[byValue].count('####')
                    print(child.name + ' is found ' + str(length) + ' times in string')
                    if length>1:
                        dictPublicMethod.append([child.name, 'byList'])
                    else:
                        dictPublicMethod.append([child.name, 'by'])
                else:
                    print(child.name, 'is a Public Property')
                    dictPublicProperty.append([child.name, 'by'])
            #Extracts string information
            elif child.has_attr('string'):
                if isDict:
                    isDict = False
                    dictPublicProperty = []
                    dictPublicMethod = []
                stringValue = child['string']
                if '####' in stringValue:
                    print(child.name, 'is a Public Method')
                    length = stringValue.count('####')
                    print(child.name + ' is found ' + str(length) + ' times in string')
                    if length>1:
                        dictPublicMethod.append([child.name, 'stringList'])
                    else:
                        dictPublicMethod.append([child.name, 'string'])
                else:
                    print(child.name, 'is a Public Property')
                    dictPublicProperty.append([child.name, 'string'])
            #extracts Column information
            elif child.has_attr('field'):
                if isDict:
                    isDict = False
                    dictPublicProperty = []
                    dictPublicMethod = []
                field = child['field']
                dataTitle = child['data-title']
                dataField = child['data-field']

                #format of Private Variable -> Columns[Section Name] is in '_column[Section Name][field value]
                columnName = '_column' + name + field

                #format of Private Properties->XElements is Columns[Section Name], also sub-region name for Private Variables
                columnSection = 'Columns' + name

                #format of Private Variables -> XElements variable names are in format _column[Section Name]
                xElementName = '_columns' + name

                #format of Public Properties naming scheme
                columnField = 'Column' + name + field

                #If Column Section has not been added yet do this stuff for the first time
                if not columnSection in regionPrivateVariables:
                    regionPrivateVariables[columnSection] = []
                    regionPrivateVariables['XElements'].append(xElementName)
                    #regionPrivateProperties['XElements'].append(columnSection)
                    columnTree = Tree(columnSection)
                    #Mark Parent node as it being a KendoGrid Column
                    columnTree.column = True
                    privatePropertyTree.add_child(columnTree)



                #Add column name to Private Properties -> XElements
                regionPrivateVariables[columnSection].append(columnName)

                #Add column to PublicProperty
                dictPublicProperty.append([columnField, 'column', field])
            else:
                #Must be a sub section. Parse it
                if not name in dictPublicProperty:
                    dictPublicProperty[child.name]={}
                    dictPublicMethod[child.name] = {}
                dictPublicProperty[child.name], dictPublicMethod[child.name], subTree = ParseSection(child)
                privatePropertyTree.add_child(subTree)

    return dictPublicProperty, dictPublicMethod, privatePropertyTree

print("+++++Program Start++++++++++++")

elementsFileLocation = "C:\\Test\\ElementsNHSNEventForm.xml"


#This is where you select which part of Elements to build against
search = "NHSNEventFormPage"
'''
try:
    count = 1
    ditch=''
    xml_doc=''
    with open(elementsFileLocation, 'r') as content_file:
        if count==1:
            ditch = content_file.read()
            count +=1
        else:
            xml_doc = content_file.read()
except IOError as error:
    print("I/O error: {}".format(error))
except ValueError as error:
    print("ValueError error: {}".format(error))
except:
    print("Unexpected error:", sys.exc_info()[0])
    raise
'''

xml_doc = open(elementsFileLocation).read()
#xml_doc = xml_doc.replace("\n", "")
#xml_doc = '''<?xml version="1.0" encoding="utf-8" ?><root>  <HotListEditTemplatePage>    <TemplateTitle by="id" id="hotlist_template_title"></TemplateTitle>    <DeleteTemplate by="id" id="btnDeleteTemplate"></DeleteTemplate>    <DeleteConfirmation>      <DeleteYes by="id" id="delete_template_yes"></DeleteYes>      <DeleteNo by="id" id="delete_template_no"></DeleteNo>    </DeleteConfirmation>  </HotListEditTemplatePage>  <HotListReportResultsPage>    <Breadcrumb>      <Home by="cssselector" cssselector=".breadcrumb>ul>li:nth-child(1)"></Home>      <RunReport by="cssselector" cssselector=".breadcrumb>ul>li:nth-child(3)"></RunReport>      <ReportTitle by="cssselector" cssselector=".breadcrumb>ul>li:nth-child(5)"></ReportTitle>    </Breadcrumb>    <ReportGrid>      <MenuBar>        <ReportCriteria by="id" id="btnReportCriteria"></ReportCriteria>        <UserPreferences by="id" id="btnUserPreferences"></UserPreferences>        <Graph by="id" id="iconGraph"></Graph>        <ExcelExport by="id" id="iconExcelExport"></ExcelExport>        <Print by="id" id="iconPrint"></Print>        <HotListTemplateCriteriaWindowGrid>          <Column field="Ref" data-title="Ref" data-field="criteriaId"></Column>          <Column field="Location" data-title="Loc" data-field="location"></Column>          <Column field="Source" data-title="Source" data-field="source"></Column>          <Column field="LOSDays" data-title="LOS (Days)" data-field="lengthOfStayOperator"></Column>          <Column field="LOS" data-title="LoS" data-field="lengthOfStay"></Column>          <Column field="Organism" data-title="Org" data-field="organism"></Column>          <Column field="Drug" data-title="Drug" data-field="drug"></Column>          <Column field="Susc" data-title="Sens" data-field="sensitivity"></Column>          <Column field="Results" data-title="Results" data-field="total"></Column>          <HotListTemplateCriteriaWindow by="id" id="HotListTemplateCriteriaWindow"></HotListTemplateCriteriaWindow>          <CriteriaWindow by="cssselector" cssselector=".k-widget.k-window"></CriteriaWindow>        </HotListTemplateCriteriaWindowGrid>      </MenuBar>      <KendoGrid>        <Column field="Site" data-title="Site" data-field="ShortSiteName"></Column>        <Column field="Collected Loc" data-title="Collected Loc" data-field="Location"></Column>        <Column field="Last Loc" data-title="Last Loc" data-field="LastLocation"></Column>        <Column field="Last Date" data-title="Last Date" data-field="LastDate"></Column>        <Column field="MR#" data-title="MR#" data-field="MRN"></Column>        <Column field="Patient Name" data-title="Patient Name" data-field="PatientName"></Column>        <Column field="Age" data-title="Age" data-field="Age"></Column>        <Column field="Admitted On" data-title="Admitted On" data-field="EncounterDate"></Column>        <Column field="Collected On" data-title="Collected On" data-field="DateCollected"></Column>        <Column field="LOS" data-title="LOS" data-field="LengthOfStay"></Column>        <Column field="Source" data-title="Source" data-field="Source"></Column>        <Column field="Organism" data-title="Organism" data-field="Organism"></Column>        <Column field="NIM" data-title="NIM" data-field="EventForm.Nim_final_id"></Column>        <Column field="Form" data-title="Form" data-field="EventForm"></Column>        <Column field="Doctor" data-title="Doctor" data-field="Doctor"></Column>        <Column field="Ref" data-title="Ref" data-field="HotListId"></Column>        <Column field="Message Id" data-title="Message Id" data-field="MessageId"></Column>        <Column field="Susceptibility" data-title="Susceptibility" data-field="SusceptibilityColumn"></Column>        <Column field="Observations" data-title="Observations" data-field="Org"></Column>        <Column field="Account Num" data-title="Account Num" data-field="AccountNumColumn"></Column>        <Column field="Accession Number" data-title="Accession Number" data-field="Specimen"></Column>        <HotListReportGrid by="id" id="HotListReportGrid"></HotListReportGrid>         <FilterApplyButton by="cssselector" cssselector=".k-button[type='submit']"></FilterApplyButton>        <FilterClearButton by="cssselector" cssselector=".k-button[type='reset']"></FilterClearButton>        <Tooltip by="id" id="tooltip-####"></Tooltip>      </KendoGrid>    </ReportGrid>  </HotListReportResultsPage>  <HotListRunReportPage>    <IFrame by="cssselector" cssselector="#modalmenu iframe"></IFrame>    <WindowTitle by="id" id="modalmenu_wnd_title"></WindowTitle>    <NoMatches by="id" id="nomatch"></NoMatches>    <ReportSection>      <ReportSectionDiv by="id" id="dvRun_ReportSection"></ReportSectionDiv>           <ReportTemplate by="cssselector" cssselector="div.dvRun_dropdownlist span[aria-owns='ReportTemplates_listbox']"></ReportTemplate>      <ListAllTemplates by="id" id="AllTemplates"></ListAllTemplates>      <MultiSelectSites by="string" string="#MultiSelectSites"></MultiSelectSites>    </ReportSection>    <CommonSection>      <CriteriaGrid>        <Column field="Location" data-title="Location" data-field="location"></Column>        <Column field="Source" data-title="Source" data-field="source"></Column>        <Column field="LOS" data-title="LOS" data-field="length_of_stay"></Column>        <Column field="Organism" data-title="Organism" data-field="organism"></Column>        <Column field="Drug" data-title="Drug" data-field="drug"></Column>        <Column field="Susc" data-title="Susc" data-field="sensitivity"></Column>        <TemplateCriteriaGrid by="id" id="TemplateCriteriaGrid"></TemplateCriteriaGrid>      </CriteriaGrid>      <CommonSectionDiv by="id" id="dvRun_CommonSection"></CommonSectionDiv>      <TimeFrame by="cssselector" cssselector="div.dvRun_dropdownlist span[aria-owns='ReportTimeFrame_listbox']"></TimeFrame>      <RunDates by="id" id="dvRun_Dates"></RunDates>      <CollectedRadioBtn by="cssselector" cssselector="input[value='collected']"></CollectedRadioBtn>      <FinaledRadioBtn by="cssselector" cssselector="input[value='finaled']"></FinaledRadioBtn>      <NonPositiveCheckBox by="id" id="hiddenResults"></NonPositiveCheckBox>      <ReportCriteria by="id" id="TemplateCriteriaGrid"></ReportCriteria>      <RunReportButton by="id" id="runReport"></RunReportButton>      <CancelButton by="id" id="cancel"></CancelButton>    </CommonSection>     </HotListRunReportPage>  <HotListCreateTemplatePage>    <TitleTextBox by="id" id="ReportTemplateName"></TitleTextBox>  </HotListCreateTemplatePage>  <HotListTemplatePage>    <Breadcrumb>      <Home by="cssselector" cssselector=".breadcrumb>ul>li>a"></Home>    </Breadcrumb>    <CriteriaSelection>      <BtnAddCriteria by="id" id="btnAddCriteria"></BtnAddCriteria>      <SearchCriteria by="id" id="SearchCriteria"></SearchCriteria>      <SearchDrugs by="id" id="SearchDrugs"></SearchDrugs>      <SearchLocations by="id" id="SearchLocations"></SearchLocations>      <SearchLOS by="id" id="SearchLOS"></SearchLOS>      <SearchLOSDays by="id" id="SearchLOSDays"></SearchLOSDays>      <SearchOrganisms by="id" id="SearchOrganisms"></SearchOrganisms>      <SearchSources by="id" id="SearchSources"></SearchSources>      <SearchSusceptibilities by="id" id="SearchSusceptibilities"></SearchSusceptibilities>          </CriteriaSelection>    <CriteriaGrid>      <Column field="Location" data-title="Location" data-field="location"></Column>      <Column field="Source" data-title="Source" data-field="source"></Column>      <Column field="LOSDays" data-title="LOS (Days)" data-field="length_of_stay_operator"></Column>      <Column field="LOS" data-title="length_ of_ stay" data-field="length_of_stay"></Column>      <Column field="Organism" data-title="Organism" data-field="organism"></Column>      <Column field="Drug" data-title="Drug" data-field="drug"></Column>      <Column field="Susc" data-title="Susc" data-field="sensitivity"></Column>      <HotListCriteriaGrid by="id" id="HotListCriteriaGrid"></HotListCriteriaGrid>      <EditTextBox by="id" id="####"></EditTextBox>    </CriteriaGrid>    <TemplateOptions>      <BtnRunReport by="id" id="btnRunReport"></BtnRunReport>      <BtnSaveTemplate by="id" id="btnSaveTemplate"></BtnSaveTemplate>      <BtnCancel by="id" id="btnCancel"></BtnCancel>      <TemplateStatus by="id" id="template_status"></TemplateStatus>      <TemplateStatusMessage by="id" id="template_status_message"></TemplateStatusMessage>    </TemplateOptions>  </HotListTemplatePage>  <KendoPage>    <KendoGrid>      <PageNavigation>        <GridPageInfo by="cssselector" cssselector="span.k-pager-info.k-label"></GridPageInfo>        <GridNavFirstPage by="cssselector" cssselector="a[title='Go to the first page']"></GridNavFirstPage>        <GridNavLastPage by="cssselector" cssselector="a[title='Go to the last page']"></GridNavLastPage>        <GridNavNextPage by="cssselector" cssselector="a[title='Go to the next page']"></GridNavNextPage>        <GridNavPreviousPage by="cssselector" cssselector="a[title='Go to the previous page']"></GridNavPreviousPage>        <GridNavPageNumber by="cssselector" cssselector="a[data-page='####']"></GridNavPageNumber>      </PageNavigation>    </KendoGrid>     </KendoPage>  <PatternDetailPage>    <SidePanel>      <SidePanelShow by="classname" classname="RightPanHeader"></SidePanelShow>      <ChangeStatusButton by="cssselector" cssselector="button[onclick=' PatternStatusDropDownShowHide(); ']"></ChangeStatusButton>      <ChangeStatusDisplay by="id" id="Status"></ChangeStatusDisplay>      <ChangeStatusUnpublish by="cssselector" cssselector="div#Status a[data-ajax-begin='return ConfirmStatusChange(1)']"></ChangeStatusUnpublish>    </SidePanel>  </PatternDetailPage>  <PatternGridPage>    <KendoGrid>      <Column field="Pattern" data-title="Pattern" data-field="PatternTk"></Column>      <Column field="Run Date" data-title="Run Date" data-field="IncidenceDate"></Column>      <Column field="Specimen Source" data-title="Specimen Source" data-field="SpecimenSource"></Column>      <Column field="Organism" data-title="Organism" data-field="Organism"></Column>      <Column field="Resistance" data-title="Resistance" data-field="Resistance"></Column>      <Column field="Locations" data-title="Locations" data-field="Locations"></Column>      <Column field="Onset" data-title="Onset" data-field="Onset"></Column>      <Column field="Type" data-title="Type" data-field="IncidenceName"></Column>      <Column field="Status" data-title="Status" data-field="PatternStatus"></Column>      <Column field="Binder" data-title="Binder" data-field="IsBinded"></Column>      <GridFilterDivRunDate by="id" id="dvInnerfilIncidenceDate"></GridFilterDivRunDate>      <GridFilterDivPatternTk by="id" id="dvInnerfilPatternTk"></GridFilterDivPatternTk>      <GridFilterDivSpecimenSource by="id" id="dvInnerfilSpecimenSource"></GridFilterDivSpecimenSource>      <GridFilterDivOrganism by="id" id="dvInnerfilOrganism"></GridFilterDivOrganism>      <GridFilterDivResistance by="id" id="dvInnerfilResistance"></GridFilterDivResistance>      <GridFilterDivLocations by="id" id="dvInnerfilLocations"></GridFilterDivLocations>      <GridFilterDivOnset by="id" id="dvInnerfilOnset"></GridFilterDivOnset>      <GridFilterDivType by="id" id="dvfilIncidenceName"></GridFilterDivType>      <GridFilterDivStatus by="id" id="dvfilPatternStatus"></GridFilterDivStatus>      <GridFilterDivBinder by="id" id="dvInnerfilIsBinded"></GridFilterDivBinder>           <FilterCheckBoxOption by="string" string="input[value='####'][name='####']"></FilterCheckBoxOption>      <FilterApplyBtn by="id" id="apply####"></FilterApplyBtn>      <FilterCancelBtn by="id" id="cancel####"></FilterCancelBtn>      <FilterClearBtn by="id" id="Clear####"></FilterClearBtn>      <FilterSelectAll by="string" string="input#checkall####"></FilterSelectAll>      <Table>        <SuggestedActionAreaHidden by="cssselector" cssselector="tr[class='trAdditionalData']"></SuggestedActionAreaHidden>        <SuggestedActionAreaVisible by="cssselector" cssselector="td.mgraph"></SuggestedActionAreaVisible>        <SuggestedActionArrowUp by="cssselector" cssselector="img[src='Content/Images/icon_arrow_top.png']"></SuggestedActionArrowUp>        <SuggestedActionArrowDown by="cssselector" cssselector="img[src='Content/Images/icon_arrow_bot.png']"></SuggestedActionArrowDown>        <StatusColumnPublishIcon by="cssselector" cssselector="a[onclick^='UnpublishUnderReview']"></StatusColumnPublishIcon>        <PatternColumnPatternTkLink by="cssselector" cssselector="a[href^='pattern/detail/####/####"></PatternColumnPatternTkLink>      </Table>    </KendoGrid>    <TopMenu>      <GridPageSizeDropDown by="id" id="GridPageSize"></GridPageSizeDropDown>      <SiteNameDisplayedInMenuBar by="cssselector" cssselector="div#DivPatternGrid div.menuBar div.menuText span"></SiteNameDisplayedInMenuBar>      <ExpandAllBtn by="id" id="btnExpandAll"></ExpandAllBtn>      <SettingsIcon by="cssselector" cssselector="td a[href*='/preferences']"></SettingsIcon>      <ReturnToHomePage by="cssselector" cssselector="a[href='/phoenix/']"></ReturnToHomePage>      <PublishPatternsIcon by="cssselector" cssselector="img[title='Publish UnderReview Patterns']"></PublishPatternsIcon>      <HiddenPatternsIcon by="id" id="imgToggleHiddenPatterns"></HiddenPatternsIcon>      <Dates>        <HiddenFromDate by="id" id="hdnFromDate"></HiddenFromDate>        <HiddenToDate by="id" id="hdnToDate"></HiddenToDate>        <DatePicker by="id" id="open"></DatePicker>        <DatePickerSubmitBtn by="id" id="btnGo"></DatePickerSubmitBtn>      </Dates>    </TopMenu>       </PatternGridPage>  </root>'''
#soup = BeautifulSoup(xml_doc, "xml")
soup = BeautifulSoup(xml_doc, ["lxml", "xml"])
root = soup.root
node = root.find(search)
print("----------------------")

child = node.contents
print("----------------------")

regionPrivateVariables = {}
regionPublicProperties = {}
regionPrivateProperties = {}
regionPublicMethods = {}

regionPrivateVariables['XElements'] = []
regionPublicProperties[search] = {}
regionPublicMethods[search] = {}

regionPublicProperties[search],regionPublicMethods[search], regionPrivateProperties  = ParseSection(node)

print('++++++++Private Variables++++++++++')
print(regionPrivateVariables)

print('++++++++Private Properties++++++++++')
regionPrivateProperties.print()

print('++++++++Public Properties++++++++++')
print(regionPublicProperties)

print('++++++++Public Methods++++++++++')
print(regionPublicMethods)

print('++++++++Region Private Variables++++++++++')
formattedPrivateVariables = FormatPrivateVariables()
#print(formattedPrivateVariables)

print('++++++++Region Private Properties++++++++++')
formattedPrivateProperties = FormatPrivateProperties()
#print(formattedPrivateProperties)

print('++++++++Region Public Properties++++++++++')
formattedPublicProperties = FormatPublicProperties()
#print(formattedPublicProperties)

print('++++++++Region Public Methods++++++++++')
formattedPublicMethods = FormatPublicMethods()
#print(formattedPublicMethods)

#print(formattedPrivateVariables, formattedPublicProperties, formattedPrivateProperties, formattedPublicMethods)

try:
    out_file = open("PageElements.cs", "wt")
    formattedStr = formattedPrivateVariables + '\n\n' + formattedPublicProperties + '\n\n' + formattedPrivateProperties \
                   + '\n\n' + formattedPublicMethods
    out_file.write(formattedStr)
except IOError as error:
    print("I/O error: {}".format(error))
except ValueError as error:
    print("ValueError error: {}".format(error))
except:
    print("Unexpected error:", sys.exc_info()[0])
    raise