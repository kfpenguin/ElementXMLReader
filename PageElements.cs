#region Private Variables

#region XElements

    /// <summary>
    /// Contains All nHSNEventFormPage Elements from xml file
    /// </summary>
    private static IEnumerable<XElement> _nHSNEventFormPage = null;
    
    /// <summary>
    /// Contains All global Elements from xml file
    /// </summary>
    private static IEnumerable<XElement> _global = null;
    
    /// <summary>
    /// Contains All bSI Elements from xml file
    /// </summary>
    private static IEnumerable<XElement> _bSI = null;
    
    /// <summary>
    /// Contains All sSI Elements from xml file
    /// </summary>
    private static IEnumerable<XElement> _sSI = null;
    
    /// <summary>
    /// Contains All pNEU Elements from xml file
    /// </summary>
    private static IEnumerable<XElement> _pNEU = null;
    
    /// <summary>
    /// Contains All uTI Elements from xml file
    /// </summary>
    private static IEnumerable<XElement> _uTI = null;
    
    /// <summary>
    /// Contains All dE Elements from xml file
    /// </summary>
    private static IEnumerable<XElement> _dE = null;
    
    /// <summary>
    /// Contains All other Elements from xml file
    /// </summary>
    private static IEnumerable<XElement> _other = null;
    
    /// <summary>
    /// Contains All cLIP Elements from xml file
    /// </summary>
    private static IEnumerable<XElement> _cLIP = null;
    
    /// <summary>
    /// Contains All lABID Elements from xml file
    /// </summary>
    private static IEnumerable<XElement> _lABID = null;
    
    /// <summary>
    /// Contains All validation Elements from xml file
    /// </summary>
    private static IEnumerable<XElement> _validation = null;
    
    /// <summary>
    /// Contains All duplicateEventsFound Elements from xml file
    /// </summary>
    private static IEnumerable<XElement> _duplicateEventsFound = null;
    
#endregion

#endregion

#region Public Properties

#region NHSNEventFormPage

#region SSI

/// <summary>
/// Gets the By for DischargeDate SSI element
/// </summary>
public static By DischargeDate
{
    get
    {
        return Elements.GetByValue("DischargeDate", SSI);
    }
}

/// <summary>
/// Gets the By for DischargeDate2 SSI element
/// </summary>
public static By DischargeDate2
{
    get
    {
        return Elements.GetByValue("DischargeDate2", SSI);
    }
}

#endregion

#region DE

/// <summary>
/// Gets the By for VAComment DE element
/// </summary>
public static By VAComment
{
    get
    {
        return Elements.GetByValue("VAComment", DE);
    }
}

/// <summary>
/// Gets the By for APMonthFistula DE element
/// </summary>
public static By APMonthFistula
{
    get
    {
        return Elements.GetByValue("APMonthFistula", DE);
    }
}

/// <summary>
/// Gets the By for APYearFistula DE element
/// </summary>
public static By APYearFistula
{
    get
    {
        return Elements.GetByValue("APYearFistula", DE);
    }
}

/// <summary>
/// Gets the By for APMonthGraft DE element
/// </summary>
public static By APMonthGraft
{
    get
    {
        return Elements.GetByValue("APMonthGraft", DE);
    }
}

/// <summary>
/// Gets the By for APYearGraft DE element
/// </summary>
public static By APYearGraft
{
    get
    {
        return Elements.GetByValue("APYearGraft", DE);
    }
}

/// <summary>
/// Gets the By for APMonthTunneledCentralLine DE element
/// </summary>
public static By APMonthTunneledCentralLine
{
    get
    {
        return Elements.GetByValue("APMonthTunneledCentralLine", DE);
    }
}

/// <summary>
/// Gets the By for APYearTunneledCentralLine DE element
/// </summary>
public static By APYearTunneledCentralLine
{
    get
    {
        return Elements.GetByValue("APYearTunneledCentralLine", DE);
    }
}

/// <summary>
/// Gets the By for APMonthNonTunneledCentralLine DE element
/// </summary>
public static By APMonthNonTunneledCentralLine
{
    get
    {
        return Elements.GetByValue("APMonthNonTunneledCentralLine", DE);
    }
}

/// <summary>
/// Gets the By for APYearNonTunneledCentralLine DE element
/// </summary>
public static By APYearNonTunneledCentralLine
{
    get
    {
        return Elements.GetByValue("APYearNonTunneledCentralLine", DE);
    }
}

/// <summary>
/// Gets the By for APMonthOther DE element
/// </summary>
public static By APMonthOther
{
    get
    {
        return Elements.GetByValue("APMonthOther", DE);
    }
}

/// <summary>
/// Gets the By for APYearOther DE element
/// </summary>
public static By APYearOther
{
    get
    {
        return Elements.GetByValue("APYearOther", DE);
    }
}

/// <summary>
/// Gets the By for SpecifyProblemOtherProblem DE element
/// </summary>
public static By SpecifyProblemOtherProblem
{
    get
    {
        return Elements.GetByValue("SpecifyProblemOtherProblem", DE);
    }
}

#endregion

#region PNEU

#endregion

#region Global

/// <summary>
/// Gets the By for SiteName Global element
/// </summary>
public static By SiteName
{
    get
    {
        return Elements.GetByValue("SiteName", Global);
    }
}

/// <summary>
/// Gets the By for PatientID Global element
/// </summary>
public static By PatientID
{
    get
    {
        return Elements.GetByValue("PatientID", Global);
    }
}

/// <summary>
/// Gets the By for SocialSecurity Global element
/// </summary>
public static By SocialSecurity
{
    get
    {
        return Elements.GetByValue("SocialSecurity", Global);
    }
}

/// <summary>
/// Gets the By for LastName Global element
/// </summary>
public static By LastName
{
    get
    {
        return Elements.GetByValue("LastName", Global);
    }
}

/// <summary>
/// Gets the By for MiddleName Global element
/// </summary>
public static By MiddleName
{
    get
    {
        return Elements.GetByValue("MiddleName", Global);
    }
}

/// <summary>
/// Gets the By for FirstName Global element
/// </summary>
public static By FirstName
{
    get
    {
        return Elements.GetByValue("FirstName", Global);
    }
}

/// <summary>
/// Gets the By for MBN Global element
/// </summary>
public static By MBN
{
    get
    {
        return Elements.GetByValue("MBN", Global);
    }
}

/// <summary>
/// Gets the By for LastSeen Global element
/// </summary>
public static By LastSeen
{
    get
    {
        return Elements.GetByValue("LastSeen", Global);
    }
}

/// <summary>
/// Gets the By for BirthDate Global element
/// </summary>
public static By BirthDate
{
    get
    {
        return Elements.GetByValue("BirthDate", Global);
    }
}

/// <summary>
/// Gets the By for Comments Global element
/// </summary>
public static By Comments
{
    get
    {
        return Elements.GetByValue("Comments", Global);
    }
}

/// <summary>
/// Gets the By for AccountNumber Global element
/// </summary>
public static By AccountNumber
{
    get
    {
        return Elements.GetByValue("AccountNumber", Global);
    }
}

#endregion

#region LABID

/// <summary>
/// Gets the By for SpecificOrganismType LABID element
/// </summary>
public static string SpecificOrganismType
{
    get
    {
        return Elements.GetAttributeValue("string", "SpecificOrganismType", LABID);
    }
}

/// <summary>
/// Gets the By for SpecimenBodySiteSystem LABID element
/// </summary>
public static string SpecimenBodySiteSystem
{
    get
    {
        return Elements.GetAttributeValue("string", "SpecimenBodySiteSystem", LABID);
    }
}

/// <summary>
/// Gets the By for SpecimenSource LABID element
/// </summary>
public static string SpecimenSource
{
    get
    {
        return Elements.GetAttributeValue("string", "SpecimenSource", LABID);
    }
}

/// <summary>
/// Gets the By for DateAdmittedToFacility LABID element
/// </summary>
public static By DateAdmittedToFacility
{
    get
    {
        return Elements.GetByValue("DateAdmittedToFacility", LABID);
    }
}

/// <summary>
/// Gets the By for DateAdmittedToLocation LABID element
/// </summary>
public static By DateAdmittedToLocation
{
    get
    {
        return Elements.GetByValue("DateAdmittedToLocation", LABID);
    }
}

/// <summary>
/// Gets the By for LastDishcargeDate LABID element
/// </summary>
public static By LastDishcargeDate
{
    get
    {
        return Elements.GetByValue("LastDishcargeDate", LABID);
    }
}

#endregion

#region Other

/// <summary>
/// Gets the By for BtnUpdate Other element
/// </summary>
public static By BtnUpdate
{
    get
    {
        return Elements.GetByValue("BtnUpdate", Other);
    }
}

/// <summary>
/// Gets the By for BtnCancel Other element
/// </summary>
public static By BtnCancel
{
    get
    {
        return Elements.GetByValue("BtnCancel", Other);
    }
}

/// <summary>
/// Gets the By for BtnSaveAsNHSNApproved Other element
/// </summary>
public static By BtnSaveAsNHSNApproved
{
    get
    {
        return Elements.GetByValue("BtnSaveAsNHSNApproved", Other);
    }
}

/// <summary>
/// Gets the By for BtnSaveAsHAI Other element
/// </summary>
public static By BtnSaveAsHAI
{
    get
    {
        return Elements.GetByValue("BtnSaveAsHAI", Other);
    }
}

/// <summary>
/// Gets the By for BtnEnterCLIPForm Other element
/// </summary>
public static By BtnEnterCLIPForm
{
    get
    {
        return Elements.GetByValue("BtnEnterCLIPForm", Other);
    }
}

/// <summary>
/// Gets the By for BtnViewCLIPForm Other element
/// </summary>
public static By BtnViewCLIPForm
{
    get
    {
        return Elements.GetByValue("BtnViewCLIPForm", Other);
    }
}

/// <summary>
/// Gets the By for BtnDelete Other element
/// </summary>
public static By BtnDelete
{
    get
    {
        return Elements.GetByValue("BtnDelete", Other);
    }
}

/// <summary>
/// Gets the By for BtnAddOrganism Other element
/// </summary>
public static By BtnAddOrganism
{
    get
    {
        return Elements.GetByValue("BtnAddOrganism", Other);
    }
}

/// <summary>
/// Gets the By for BtnAddSensitivity Other element
/// </summary>
public static By BtnAddSensitivity
{
    get
    {
        return Elements.GetByValue("BtnAddSensitivity", Other);
    }
}

/// <summary>
/// Gets the By for PathogenEdit Other element
/// </summary>
public static By PathogenEdit
{
    get
    {
        return Elements.GetByValue("PathogenEdit", Other);
    }
}

/// <summary>
/// Gets the By for PathogenDelete Other element
/// </summary>
public static By PathogenDelete
{
    get
    {
        return Elements.GetByValue("PathogenDelete", Other);
    }
}

/// <summary>
/// Gets the By for EditPathogenSensitivity Other element
/// </summary>
public static By EditPathogenSensitivity
{
    get
    {
        return Elements.GetByValue("EditPathogenSensitivity", Other);
    }
}

/// <summary>
/// Gets the By for DeletePathogenSensitivity Other element
/// </summary>
public static By DeletePathogenSensitivity
{
    get
    {
        return Elements.GetByValue("DeletePathogenSensitivity", Other);
    }
}

/// <summary>
/// Gets the By for PathogenSensitivityRow Other element
/// </summary>
public static By PathogenSensitivityRow
{
    get
    {
        return Elements.GetByValue("PathogenSensitivityRow", Other);
    }
}

/// <summary>
/// Gets the By for NHSNPathogenNo Other element
/// </summary>
public static string NHSNPathogenNo
{
    get
    {
        return Elements.GetAttributeValue("string", "NHSNPathogenNo", Other);
    }
}

/// <summary>
/// Gets the By for NHSNMOrgPatient Other element
/// </summary>
public static string NHSNMOrgPatient
{
    get
    {
        return Elements.GetAttributeValue("string", "NHSNMOrgPatient", Other);
    }
}

/// <summary>
/// Gets the By for ShowAllOrganisms Other element
/// </summary>
public static By ShowAllOrganisms
{
    get
    {
        return Elements.GetByValue("ShowAllOrganisms", Other);
    }
}

/// <summary>
/// Gets the By for BtnAddOrganismSave Other element
/// </summary>
public static By BtnAddOrganismSave
{
    get
    {
        return Elements.GetByValue("BtnAddOrganismSave", Other);
    }
}

/// <summary>
/// Gets the By for BtnAddOrganismCancel Other element
/// </summary>
public static By BtnAddOrganismCancel
{
    get
    {
        return Elements.GetByValue("BtnAddOrganismCancel", Other);
    }
}

/// <summary>
/// Gets the By for AddOrganismWindow Other element
/// </summary>
public static By AddOrganismWindow
{
    get
    {
        return Elements.GetByValue("AddOrganismWindow", Other);
    }
}

/// <summary>
/// Gets the By for DisguiseMessage Other element
/// </summary>
public static By DisguiseMessage
{
    get
    {
        return Elements.GetByValue("DisguiseMessage", Other);
    }
}

/// <summary>
/// Gets the By for ProgressImage Other element
/// </summary>
public static string ProgressImage
{
    get
    {
        return Elements.GetAttributeValue("string", "ProgressImage", Other);
    }
}

/// <summary>
/// Gets the By for FooterValidationSummary Other element
/// </summary>
public static By FooterValidationSummary
{
    get
    {
        return Elements.GetByValue("FooterValidationSummary", Other);
    }
}

/// <summary>
/// Gets the By for FooterValidationSummaryID Other element
/// </summary>
public static string FooterValidationSummaryID
{
    get
    {
        return Elements.GetAttributeValue("string", "FooterValidationSummaryID", Other);
    }
}

#endregion

#region Validation

#endregion

#region UTI

#endregion

#region BSI

/// <summary>
/// Gets the By for EventType BSI element
/// </summary>
public static string EventType
{
    get
    {
        return Elements.GetAttributeValue("string", "EventType", BSI);
    }
}

/// <summary>
/// Gets the By for DateOfEventID BSI element
/// </summary>
public static string DateOfEventID
{
    get
    {
        return Elements.GetAttributeValue("string", "DateOfEventID", BSI);
    }
}

/// <summary>
/// Gets the By for DateOfEvent BSI element
/// </summary>
public static By DateOfEvent
{
    get
    {
        return Elements.GetByValue("DateOfEvent", BSI);
    }
}

/// <summary>
/// Gets the By for DateOfProcedure BSI element
/// </summary>
public static By DateOfProcedure
{
    get
    {
        return Elements.GetByValue("DateOfProcedure", BSI);
    }
}

/// <summary>
/// Gets the By for NHSNProcedureCode BSI element
/// </summary>
public static string NHSNProcedureCode
{
    get
    {
        return Elements.GetAttributeValue("string", "NHSNProcedureCode", BSI);
    }
}

/// <summary>
/// Gets the By for ICD9Code BSI element
/// </summary>
public static string ICD9Code
{
    get
    {
        return Elements.GetAttributeValue("string", "ICD9Code", BSI);
    }
}

/// <summary>
/// Gets the By for DateAdmittedtoFacility BSI element
/// </summary>
public static By DateAdmittedtoFacility
{
    get
    {
        return Elements.GetByValue("DateAdmittedtoFacility", BSI);
    }
}

/// <summary>
/// Gets the By for Location BSI element
/// </summary>
public static string Location
{
    get
    {
        return Elements.GetAttributeValue("string", "Location", BSI);
    }
}

/// <summary>
/// Gets the By for BirthWeight BSI element
/// </summary>
public static By BirthWeight
{
    get
    {
        return Elements.GetByValue("BirthWeight", BSI);
    }
}

/// <summary>
/// Gets the By for DateDeviceInsertion BSI element
/// </summary>
public static By DateDeviceInsertion
{
    get
    {
        return Elements.GetByValue("DateDeviceInsertion", BSI);
    }
}

/// <summary>
/// Gets the By for LocationDeviceInsertion BSI element
/// </summary>
public static string LocationDeviceInsertion
{
    get
    {
        return Elements.GetAttributeValue("string", "LocationDeviceInsertion", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPPersonRecordingInsertion BSI element
/// </summary>
public static By CLIPPersonRecordingInsertion
{
    get
    {
        return Elements.GetByValue("CLIPPersonRecordingInsertion", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPInserterID BSI element
/// </summary>
public static By CLIPInserterID
{
    get
    {
        return Elements.GetByValue("CLIPInserterID", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPInserterFirstName BSI element
/// </summary>
public static By CLIPInserterFirstName
{
    get
    {
        return Elements.GetByValue("CLIPInserterFirstName", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPInserterLastName BSI element
/// </summary>
public static By CLIPInserterLastName
{
    get
    {
        return Elements.GetByValue("CLIPInserterLastName", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPOccupationOfInserter BSI element
/// </summary>
public static By CLIPOccupationOfInserter
{
    get
    {
        return Elements.GetByValue("CLIPOccupationOfInserter", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPInserterMemberOfPICCIVTeam BSI element
/// </summary>
public static By CLIPInserterMemberOfPICCIVTeam
{
    get
    {
        return Elements.GetByValue("CLIPInserterMemberOfPICCIVTeam", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPReasonForInsertion BSI element
/// </summary>
public static By CLIPReasonForInsertion
{
    get
    {
        return Elements.GetByValue("CLIPReasonForInsertion", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPCentralLineExchangedOverGuidewire BSI element
/// </summary>
public static By CLIPCentralLineExchangedOverGuidewire
{
    get
    {
        return Elements.GetByValue("CLIPCentralLineExchangedOverGuidewire", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPHandHygiene BSI element
/// </summary>
public static By CLIPHandHygiene
{
    get
    {
        return Elements.GetByValue("CLIPHandHygiene", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPCentralLinePlacedEmergently BSI element
/// </summary>
public static By CLIPCentralLinePlacedEmergently
{
    get
    {
        return Elements.GetByValue("CLIPCentralLinePlacedEmergently", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPMask BSI element
/// </summary>
public static By CLIPMask
{
    get
    {
        return Elements.GetByValue("CLIPMask", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPSterileGown BSI element
/// </summary>
public static By CLIPSterileGown
{
    get
    {
        return Elements.GetByValue("CLIPSterileGown", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPLargeSterileDrape BSI element
/// </summary>
public static By CLIPLargeSterileDrape
{
    get
    {
        return Elements.GetByValue("CLIPLargeSterileDrape", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPSterileGloves BSI element
/// </summary>
public static By CLIPSterileGloves
{
    get
    {
        return Elements.GetByValue("CLIPSterileGloves", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPCap BSI element
/// </summary>
public static By CLIPCap
{
    get
    {
        return Elements.GetByValue("CLIPCap", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPSkinPreparation BSI element
/// </summary>
public static By CLIPSkinPreparation
{
    get
    {
        return Elements.GetByValue("CLIPSkinPreparation", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPSkinPrepChoiceNotChlorhexidine BSI element
/// </summary>
public static By CLIPSkinPrepChoiceNotChlorhexidine
{
    get
    {
        return Elements.GetByValue("CLIPSkinPrepChoiceNotChlorhexidine", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPSkinPrepAgentDry BSI element
/// </summary>
public static By CLIPSkinPrepAgentDry
{
    get
    {
        return Elements.GetByValue("CLIPSkinPrepAgentDry", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPInsertionSite BSI element
/// </summary>
public static By CLIPInsertionSite
{
    get
    {
        return Elements.GetByValue("CLIPInsertionSite", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPAntimicrobialCoatedCatheterUsed BSI element
/// </summary>
public static By CLIPAntimicrobialCoatedCatheterUsed
{
    get
    {
        return Elements.GetByValue("CLIPAntimicrobialCoatedCatheterUsed", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPCentralLineCatheterType BSI element
/// </summary>
public static By CLIPCentralLineCatheterType
{
    get
    {
        return Elements.GetByValue("CLIPCentralLineCatheterType", BSI);
    }
}

/// <summary>
/// Gets the By for CLIPSuccessfulCentralLinePlacement BSI element
/// </summary>
public static By CLIPSuccessfulCentralLinePlacement
{
    get
    {
        return Elements.GetByValue("CLIPSuccessfulCentralLinePlacement", BSI);
    }
}

#endregion

#region CLIP

/// <summary>
/// Gets the By for InserterID CLIP element
/// </summary>
public static By InserterID
{
    get
    {
        return Elements.GetByValue("InserterID", CLIP);
    }
}

/// <summary>
/// Gets the By for InserterFirstName CLIP element
/// </summary>
public static By InserterFirstName
{
    get
    {
        return Elements.GetByValue("InserterFirstName", CLIP);
    }
}

/// <summary>
/// Gets the By for InserterLastName CLIP element
/// </summary>
public static By InserterLastName
{
    get
    {
        return Elements.GetByValue("InserterLastName", CLIP);
    }
}

/// <summary>
/// Gets the By for OtherOccupationOfInserter CLIP element
/// </summary>
public static By OtherOccupationOfInserter
{
    get
    {
        return Elements.GetByValue("OtherOccupationOfInserter", CLIP);
    }
}

/// <summary>
/// Gets the By for OtherReasonForInsertion CLIP element
/// </summary>
public static By OtherReasonForInsertion
{
    get
    {
        return Elements.GetByValue("OtherReasonForInsertion", CLIP);
    }
}

/// <summary>
/// Gets the By for OtherSkinPreparation CLIP element
/// </summary>
public static By OtherSkinPreparation
{
    get
    {
        return Elements.GetByValue("OtherSkinPreparation", CLIP);
    }
}

/// <summary>
/// Gets the By for OtherCentralLineCatheterType CLIP element
/// </summary>
public static By OtherCentralLineCatheterType
{
    get
    {
        return Elements.GetByValue("OtherCentralLineCatheterType", CLIP);
    }
}

#endregion

#region DuplicateEventsFound

/// <summary>
/// Gets the By for DuplicatesWindow DuplicateEventsFound element
/// </summary>
public static By DuplicatesWindow
{
    get
    {
        return Elements.GetByValue("DuplicatesWindow", DuplicateEventsFound);
    }
}

/// <summary>
/// Gets the By for DuplicatesTitle DuplicateEventsFound element
/// </summary>
public static By DuplicatesTitle
{
    get
    {
        return Elements.GetByValue("DuplicatesTitle", DuplicateEventsFound);
    }
}

/// <summary>
/// Gets the By for DuplicatesText DuplicateEventsFound element
/// </summary>
public static By DuplicatesText
{
    get
    {
        return Elements.GetByValue("DuplicatesText", DuplicateEventsFound);
    }
}

/// <summary>
/// Gets the By for DuplicatesDeleteButton DuplicateEventsFound element
/// </summary>
public static By DuplicatesDeleteButton
{
    get
    {
        return Elements.GetByValue("DuplicatesDeleteButton", DuplicateEventsFound);
    }
}

/// <summary>
/// Gets the By for DuplicatesUpdateButton DuplicateEventsFound element
/// </summary>
public static By DuplicatesUpdateButton
{
    get
    {
        return Elements.GetByValue("DuplicatesUpdateButton", DuplicateEventsFound);
    }
}

/// <summary>
/// Gets the By for DuplicatesCancelButton DuplicateEventsFound element
/// </summary>
public static By DuplicatesCancelButton
{
    get
    {
        return Elements.GetByValue("DuplicatesCancelButton", DuplicateEventsFound);
    }
}

#endregion

#endregion

#endregion

#region Private Properties

/// <summary>
/// Gets the NHSNEventFormPage Elements from xml
/// </summary>
private static IEnumerable<XElement> NHSNEventFormPage
{
    get
    {
        if (_nHSNEventFormPage == null)
        {
            _nHSNEventFormPage = from d in GlobalValues.Elements.Root.Descendants("NHSNEventFormPage")
                                    select d;
        }

        return _nHSNEventFormPage;
    }
}

/// <summary>
/// Gets the Global Elements from NHSNEventFormPage
/// </summary>
private static IEnumerable<XElement> Global
{
    get
    {
        if (_global == null)
        {
            _global = from d in NHSNEventFormPage.Descendants("Global")
                                    select d;
        }

        return _global;
    }
}

/// <summary>
/// Gets the BSI Elements from NHSNEventFormPage
/// </summary>
private static IEnumerable<XElement> BSI
{
    get
    {
        if (_bSI == null)
        {
            _bSI = from d in NHSNEventFormPage.Descendants("BSI")
                                    select d;
        }

        return _bSI;
    }
}

/// <summary>
/// Gets the SSI Elements from NHSNEventFormPage
/// </summary>
private static IEnumerable<XElement> SSI
{
    get
    {
        if (_sSI == null)
        {
            _sSI = from d in NHSNEventFormPage.Descendants("SSI")
                                    select d;
        }

        return _sSI;
    }
}

/// <summary>
/// Gets the PNEU Elements from NHSNEventFormPage
/// </summary>
private static IEnumerable<XElement> PNEU
{
    get
    {
        if (_pNEU == null)
        {
            _pNEU = from d in NHSNEventFormPage.Descendants("PNEU")
                                    select d;
        }

        return _pNEU;
    }
}

/// <summary>
/// Gets the UTI Elements from NHSNEventFormPage
/// </summary>
private static IEnumerable<XElement> UTI
{
    get
    {
        if (_uTI == null)
        {
            _uTI = from d in NHSNEventFormPage.Descendants("UTI")
                                    select d;
        }

        return _uTI;
    }
}

/// <summary>
/// Gets the DE Elements from NHSNEventFormPage
/// </summary>
private static IEnumerable<XElement> DE
{
    get
    {
        if (_dE == null)
        {
            _dE = from d in NHSNEventFormPage.Descendants("DE")
                                    select d;
        }

        return _dE;
    }
}

/// <summary>
/// Gets the Other Elements from NHSNEventFormPage
/// </summary>
private static IEnumerable<XElement> Other
{
    get
    {
        if (_other == null)
        {
            _other = from d in NHSNEventFormPage.Descendants("Other")
                                    select d;
        }

        return _other;
    }
}

/// <summary>
/// Gets the CLIP Elements from NHSNEventFormPage
/// </summary>
private static IEnumerable<XElement> CLIP
{
    get
    {
        if (_cLIP == null)
        {
            _cLIP = from d in NHSNEventFormPage.Descendants("CLIP")
                                    select d;
        }

        return _cLIP;
    }
}

/// <summary>
/// Gets the LABID Elements from NHSNEventFormPage
/// </summary>
private static IEnumerable<XElement> LABID
{
    get
    {
        if (_lABID == null)
        {
            _lABID = from d in NHSNEventFormPage.Descendants("LABID")
                                    select d;
        }

        return _lABID;
    }
}

/// <summary>
/// Gets the Validation Elements from NHSNEventFormPage
/// </summary>
private static IEnumerable<XElement> Validation
{
    get
    {
        if (_validation == null)
        {
            _validation = from d in NHSNEventFormPage.Descendants("Validation")
                                    select d;
        }

        return _validation;
    }
}

/// <summary>
/// Gets the DuplicateEventsFound Elements from NHSNEventFormPage
/// </summary>
private static IEnumerable<XElement> DuplicateEventsFound
{
    get
    {
        if (_duplicateEventsFound == null)
        {
            _duplicateEventsFound = from d in NHSNEventFormPage.Descendants("DuplicateEventsFound")
                                    select d;
        }

        return _duplicateEventsFound;
    }
}

#endregion

#region Public Methods

#region NHSNEventFormPage

#region SSI

/// <summary>
/// Gets the By for Outpatient in SSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any Outpatient</returns>
public static By Outpatient(string field)
{
    By by = Elements.GetByValueWithField("Outpatient", SSI, field);
    return by;
}

/// <summary>
/// Gets the By for IncludeLocationNHSNCDAExport in SSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any IncludeLocationNHSNCDAExport</returns>
public static By IncludeLocationNHSNCDAExport(string field)
{
    By by = Elements.GetByValueWithField("IncludeLocationNHSNCDAExport", SSI, field);
    return by;
}

/// <summary>
/// Gets the By for InfectionPresentAtSurgery in SSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any InfectionPresentAtSurgery</returns>
public static By InfectionPresentAtSurgery(string field)
{
    By by = Elements.GetByValueWithField("InfectionPresentAtSurgery", SSI, field);
    return by;
}

/// <summary>
/// Gets the By for SpecifySite in SSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any SpecifySite</returns>
public static By SpecifySite(string field)
{
    By by = Elements.GetByValueWithField("SpecifySite", SSI, field);
    return by;
}

/// <summary>
/// Gets the By for Laboratory in SSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any Laboratory</returns>
public static By Laboratory(string field)
{
    By by = Elements.GetByValueWithField("Laboratory", SSI, field);
    return by;
}

/// <summary>
/// Gets the By for ClinicalDiagnosis in SSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any ClinicalDiagnosis</returns>
public static By ClinicalDiagnosis(string field)
{
    By by = Elements.GetByValueWithField("ClinicalDiagnosis", SSI, field);
    return by;
}

/// <summary>
/// Gets the By for Detected in SSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any Detected</returns>
public static By Detected(string field)
{
    By by = Elements.GetByValueWithField("Detected", SSI, field);
    return by;
}

/// <summary>
/// Gets the By for SecondaryBloodstreamInfection in SSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any SecondaryBloodstreamInfection</returns>
public static By SecondaryBloodstreamInfection(string field)
{
    By by = Elements.GetByValueWithField("SecondaryBloodstreamInfection", SSI, field);
    return by;
}

#endregion

#region DE

/// <summary>
/// Gets the By for AdmittedDialysisFacility in DE
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any AdmittedDialysisFacility</returns>
public static By AdmittedDialysisFacility(string field)
{
    By by = Elements.GetByValueWithField("AdmittedDialysisFacility", DE, field);
    return by;
}

/// <summary>
/// Gets the string for the VARiskFactors in DE
/// </summary>
/// <param name="fields">List of strings</param>
/// <returns>Returns the string value for VARiskFactors</returns>
public static By VARiskFactors(List<string> fields)
{
    By by = Elements.GetByValueWithField("VARiskFactors", DE, fields);
    return by;
}

/// <summary>
/// Gets the string for the Buttonhole in DE
/// </summary>
/// <param name="fields">List of strings</param>
/// <returns>Returns the string value for Buttonhole</returns>
public static By Buttonhole(List<string> fields)
{
    By by = Elements.GetByValueWithField("Buttonhole", DE, fields);
    return by;
}

/// <summary>
/// Gets the string for the CatheterGraftHybrid in DE
/// </summary>
/// <param name="fields">List of strings</param>
/// <returns>Returns the string value for CatheterGraftHybrid</returns>
public static By CatheterGraftHybrid(List<string> fields)
{
    By by = Elements.GetByValueWithField("CatheterGraftHybrid", DE, fields);
    return by;
}

/// <summary>
/// Gets the By for APUnknownFistula in DE
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any APUnknownFistula</returns>
public static By APUnknownFistula(string field)
{
    By by = Elements.GetByValueWithField("APUnknownFistula", DE, field);
    return by;
}

/// <summary>
/// Gets the By for APUnknownGraft in DE
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any APUnknownGraft</returns>
public static By APUnknownGraft(string field)
{
    By by = Elements.GetByValueWithField("APUnknownGraft", DE, field);
    return by;
}

/// <summary>
/// Gets the By for APUnknownTunneledCentralLine in DE
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any APUnknownTunneledCentralLine</returns>
public static By APUnknownTunneledCentralLine(string field)
{
    By by = Elements.GetByValueWithField("APUnknownTunneledCentralLine", DE, field);
    return by;
}

/// <summary>
/// Gets the By for APUnknownNonTunneledCentralLine in DE
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any APUnknownNonTunneledCentralLine</returns>
public static By APUnknownNonTunneledCentralLine(string field)
{
    By by = Elements.GetByValueWithField("APUnknownNonTunneledCentralLine", DE, field);
    return by;
}

/// <summary>
/// Gets the By for APUnknownOther in DE
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any APUnknownOther</returns>
public static By APUnknownOther(string field)
{
    By by = Elements.GetByValueWithField("APUnknownOther", DE, field);
    return by;
}

/// <summary>
/// Gets the By for TransientPatient in DE
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any TransientPatient</returns>
public static By TransientPatient(string field)
{
    By by = Elements.GetByValueWithField("TransientPatient", DE, field);
    return by;
}

/// <summary>
/// Gets the string for the SpecifyDialysisEvent in DE
/// </summary>
/// <param name="fields">List of strings</param>
/// <returns>Returns the string value for SpecifyDialysisEvent</returns>
public static By SpecifyDialysisEvent(List<string> fields)
{
    By by = Elements.GetByValueWithField("SpecifyDialysisEvent", DE, fields);
    return by;
}

/// <summary>
/// Gets the By for SpecifyProblem in DE
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any SpecifyProblem</returns>
public static By SpecifyProblem(string field)
{
    By by = Elements.GetByValueWithField("SpecifyProblem", DE, field);
    return by;
}

/// <summary>
/// Gets the By for Hospitalization in DE
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any Hospitalization</returns>
public static By Hospitalization(string field)
{
    By by = Elements.GetByValueWithField("Hospitalization", DE, field);
    return by;
}

/// <summary>
/// Gets the By for Death in DE
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any Death</returns>
public static By Death(string field)
{
    By by = Elements.GetByValueWithField("Death", DE, field);
    return by;
}

/// <summary>
/// Gets the By for LossOfVascularAccess in DE
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any LossOfVascularAccess</returns>
public static By LossOfVascularAccess(string field)
{
    By by = Elements.GetByValueWithField("LossOfVascularAccess", DE, field);
    return by;
}

/// <summary>
/// Gets the By for VancomycinAntimicrobialUsed in DE
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any VancomycinAntimicrobialUsed</returns>
public static By VancomycinAntimicrobialUsed(string field)
{
    By by = Elements.GetByValueWithField("VancomycinAntimicrobialUsed", DE, field);
    return by;
}

/// <summary>
/// Gets the string for the SuspectedSourcePositiveBloodCulture in DE
/// </summary>
/// <param name="fields">List of strings</param>
/// <returns>Returns the string value for SuspectedSourcePositiveBloodCulture</returns>
public static By SuspectedSourcePositiveBloodCulture(List<string> fields)
{
    By by = Elements.GetByValueWithField("SuspectedSourcePositiveBloodCulture", DE, fields);
    return by;
}

/// <summary>
/// Gets the By for AccessSitesWithPusRednessSwelling in DE
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any AccessSitesWithPusRednessSwelling</returns>
public static By AccessSitesWithPusRednessSwelling(string field)
{
    By by = Elements.GetByValueWithField("AccessSitesWithPusRednessSwelling", DE, field);
    return by;
}

#endregion

#region PNEU

/// <summary>
/// Gets the By for Ventilator in PNEU
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any Ventilator</returns>
public static By Ventilator(string field)
{
    By by = Elements.GetByValueWithField("Ventilator", PNEU, field);
    return by;
}

/// <summary>
/// Gets the By for Immunocompromised in PNEU
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any Immunocompromised</returns>
public static By Immunocompromised(string field)
{
    By by = Elements.GetByValueWithField("Immunocompromised", PNEU, field);
    return by;
}

/// <summary>
/// Gets the By for XRay in PNEU
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any XRay</returns>
public static By XRay(string field)
{
    By by = Elements.GetByValueWithField("XRay", PNEU, field);
    return by;
}

#endregion

#region Global

/// <summary>
/// Gets the By for Gender in Global
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any Gender</returns>
public static By Gender(string field)
{
    By by = Elements.GetByValueWithField("Gender", Global, field);
    return by;
}

/// <summary>
/// Gets the By for Ethnicity in Global
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any Ethnicity</returns>
public static By Ethnicity(string field)
{
    By by = Elements.GetByValueWithField("Ethnicity", Global, field);
    return by;
}

/// <summary>
/// Gets the By for Race in Global
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any Race</returns>
public static By Race(string field)
{
    By by = Elements.GetByValueWithField("Race", Global, field);
    return by;
}

#endregion

#region LABID

/// <summary>
/// Gets the By for DischargedPast3Months in LABID
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any DischargedPast3Months</returns>
public static By DischargedPast3Months(string field)
{
    By by = Elements.GetByValueWithField("DischargedPast3Months", LABID, field);
    return by;
}

#endregion

#region Other

/// <summary>
/// Gets the By for EditPathogen in Other
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any EditPathogen</returns>
public static By EditPathogen(string field)
{
    By by = Elements.GetByValueWithField("EditPathogen", Other, field);
    return by;
}

/// <summary>
/// Gets the By for DeletePathogen in Other
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any DeletePathogen</returns>
public static By DeletePathogen(string field)
{
    By by = Elements.GetByValueWithField("DeletePathogen", Other, field);
    return by;
}

/// <summary>
/// Gets the By for PathogenRow in Other
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any PathogenRow</returns>
public static By PathogenRow(string field)
{
    By by = Elements.GetByValueWithField("PathogenRow", Other, field);
    return by;
}

#endregion

#region Validation

/// <summary>
/// Gets the By for InputFromLabel in Validation
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any InputFromLabel</returns>
public static By InputFromLabel(string field)
{
    By by = Elements.GetByValueWithField("InputFromLabel", Validation, field);
    return by;
}

#endregion

#region UTI

/// <summary>
/// Gets the By for UrinaryCatheterStatus in UTI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any UrinaryCatheterStatus</returns>
public static By UrinaryCatheterStatus(string field)
{
    By by = Elements.GetByValueWithField("UrinaryCatheterStatus", UTI, field);
    return by;
}

#endregion

#region BSI

/// <summary>
/// Gets the By for PostProcedureBSI in BSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any PostProcedureBSI</returns>
public static By PostProcedureBSI(string field)
{
    By by = Elements.GetByValueWithField("PostProcedureBSI", BSI, field);
    return by;
}

/// <summary>
/// Gets the By for MDROInfectionSurveillance in BSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any MDROInfectionSurveillance</returns>
public static By MDROInfectionSurveillance(string field)
{
    By by = Elements.GetByValueWithField("MDROInfectionSurveillance", BSI, field);
    return by;
}

/// <summary>
/// Gets the By for CentralLine in BSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any CentralLine</returns>
public static By CentralLine(string field)
{
    By by = Elements.GetByValueWithField("CentralLine", BSI, field);
    return by;
}

/// <summary>
/// Gets the By for CentralLineUmbilicalCatheter in BSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any CentralLineUmbilicalCatheter</returns>
public static By CentralLineUmbilicalCatheter(string field)
{
    By by = Elements.GetByValueWithField("CentralLineUmbilicalCatheter", BSI, field);
    return by;
}

/// <summary>
/// Gets the By for MedMinedInternalDocumentation in BSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any MedMinedInternalDocumentation</returns>
public static By MedMinedInternalDocumentation(string field)
{
    By by = Elements.GetByValueWithField("MedMinedInternalDocumentation", BSI, field);
    return by;
}

/// <summary>
/// Gets the By for PermanentCentralLine in BSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any PermanentCentralLine</returns>
public static By PermanentCentralLine(string field)
{
    By by = Elements.GetByValueWithField("PermanentCentralLine", BSI, field);
    return by;
}

/// <summary>
/// Gets the By for TemporaryCentralLine in BSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any TemporaryCentralLine</returns>
public static By TemporaryCentralLine(string field)
{
    By by = Elements.GetByValueWithField("TemporaryCentralLine", BSI, field);
    return by;
}

/// <summary>
/// Gets the By for SpecificEvent in BSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any SpecificEvent</returns>
public static By SpecificEvent(string field)
{
    By by = Elements.GetByValueWithField("SpecificEvent", BSI, field);
    return by;
}

/// <summary>
/// Gets the By for SignsSymptoms in BSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any SignsSymptoms</returns>
public static By SignsSymptoms(string field)
{
    By by = Elements.GetByValueWithField("SignsSymptoms", BSI, field);
    return by;
}

/// <summary>
/// Gets the By for LaboratoryBSI in BSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any LaboratoryBSI</returns>
public static By LaboratoryBSI(string field)
{
    By by = Elements.GetByValueWithField("LaboratoryBSI", BSI, field);
    return by;
}

/// <summary>
/// Gets the By for UnderlyingConditionsMBILCBI in BSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any UnderlyingConditionsMBILCBI</returns>
public static By UnderlyingConditionsMBILCBI(string field)
{
    By by = Elements.GetByValueWithField("UnderlyingConditionsMBILCBI", BSI, field);
    return by;
}

/// <summary>
/// Gets the By for Died in BSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any Died</returns>
public static By Died(string field)
{
    By by = Elements.GetByValueWithField("Died", BSI, field);
    return by;
}

/// <summary>
/// Gets the By for NHSNApproved in BSI
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any NHSNApproved</returns>
public static By NHSNApproved(string field)
{
    By by = Elements.GetByValueWithField("NHSNApproved", BSI, field);
    return by;
}

#endregion

#region CLIP

/// <summary>
/// Gets the By for PersonRecordingInsertion in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any PersonRecordingInsertion</returns>
public static By PersonRecordingInsertion(string field)
{
    By by = Elements.GetByValueWithField("PersonRecordingInsertion", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for OccupationOfInserter in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any OccupationOfInserter</returns>
public static By OccupationOfInserter(string field)
{
    By by = Elements.GetByValueWithField("OccupationOfInserter", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for InserterMemberOfPICCIVTeam in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any InserterMemberOfPICCIVTeam</returns>
public static By InserterMemberOfPICCIVTeam(string field)
{
    By by = Elements.GetByValueWithField("InserterMemberOfPICCIVTeam", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for ReasonForInsertion in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any ReasonForInsertion</returns>
public static By ReasonForInsertion(string field)
{
    By by = Elements.GetByValueWithField("ReasonForInsertion", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for CentralLineExchangedOverGuidewire in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any CentralLineExchangedOverGuidewire</returns>
public static By CentralLineExchangedOverGuidewire(string field)
{
    By by = Elements.GetByValueWithField("CentralLineExchangedOverGuidewire", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for HandHygiene in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any HandHygiene</returns>
public static By HandHygiene(string field)
{
    By by = Elements.GetByValueWithField("HandHygiene", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for CentralLinePlacedEmergently in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any CentralLinePlacedEmergently</returns>
public static By CentralLinePlacedEmergently(string field)
{
    By by = Elements.GetByValueWithField("CentralLinePlacedEmergently", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for Mask in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any Mask</returns>
public static By Mask(string field)
{
    By by = Elements.GetByValueWithField("Mask", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for SterileGown in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any SterileGown</returns>
public static By SterileGown(string field)
{
    By by = Elements.GetByValueWithField("SterileGown", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for LargeSterileDrape in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any LargeSterileDrape</returns>
public static By LargeSterileDrape(string field)
{
    By by = Elements.GetByValueWithField("LargeSterileDrape", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for SterileGloves in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any SterileGloves</returns>
public static By SterileGloves(string field)
{
    By by = Elements.GetByValueWithField("SterileGloves", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for Cap in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any Cap</returns>
public static By Cap(string field)
{
    By by = Elements.GetByValueWithField("Cap", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for SkinPreparation in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any SkinPreparation</returns>
public static By SkinPreparation(string field)
{
    By by = Elements.GetByValueWithField("SkinPreparation", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for SkinPrepChoiceNotChlorhexidine in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any SkinPrepChoiceNotChlorhexidine</returns>
public static By SkinPrepChoiceNotChlorhexidine(string field)
{
    By by = Elements.GetByValueWithField("SkinPrepChoiceNotChlorhexidine", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for SkinPrepAgentDry in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any SkinPrepAgentDry</returns>
public static By SkinPrepAgentDry(string field)
{
    By by = Elements.GetByValueWithField("SkinPrepAgentDry", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for InsertionSite in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any InsertionSite</returns>
public static By InsertionSite(string field)
{
    By by = Elements.GetByValueWithField("InsertionSite", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for AntimicrobialCoatedCatheterUsed in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any AntimicrobialCoatedCatheterUsed</returns>
public static By AntimicrobialCoatedCatheterUsed(string field)
{
    By by = Elements.GetByValueWithField("AntimicrobialCoatedCatheterUsed", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for CentralLineCatheterType in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any CentralLineCatheterType</returns>
public static By CentralLineCatheterType(string field)
{
    By by = Elements.GetByValueWithField("CentralLineCatheterType", CLIP, field);
    return by;
}

/// <summary>
/// Gets the By for SuccessfulCentralLinePlacement in CLIP
/// </summary>
/// <param name="field">Name of field</param>
/// <returns>Returns By for any SuccessfulCentralLinePlacement</returns>
public static By SuccessfulCentralLinePlacement(string field)
{
    By by = Elements.GetByValueWithField("SuccessfulCentralLinePlacement", CLIP, field);
    return by;
}

#endregion

#region DuplicateEventsFound

#endregion

#endregion

#endregion