namespace EnterpriseSystems.Data.Model.Constants
{
    public class AppointmentColumnNames
    {
        public const string Identity = "REQ_ETY_SCH_I";
        public const string EntityName = "ETY_NM";
        public const string EntityIdentity = "ETY_KEY_I";
        public const string SequenceNumber = "SEQ_NBR";
        public const string FunctionType = "SCH_FUN_TYP";
        public const string AppointmentBegin = "BEG_S";
        public const string AppointmentEnd = "END_S";
        public const string TimezoneDescription = "TZ_TYP_DSC";
        public const string Status = "PRS_STT";
        public const string CreatedDate = "CRT_S";
        public const string CreatedUserId = "CRT_UID";
        public const string CreatedProgramCode = "CRT_PGM_C";
        public const string LastUpdatedDate = "LST_UPD_S";
        public const string LastUpdatedUserId = "LST_UPD_UID";
        public const string LastUpdatedProgramCode = "LST_UPD_PGM_C";
    }

    public class CommentColumnNames
    {
        public const string Identity = "REQ_ETY_CMM_I";
        public const string EntityName = "ETY_NM";
        public const string EntityIdentity = "ETY_KEY_I";
        public const string SequenceNumber = "SEQ_NBR";
        public const string CommentType = "CMM_TYP";
        public const string CommentText = "CMM_TXT";
        public const string CreatedDate = "CRT_S";
        public const string CreatedUserId = "CRT_UID";
        public const string CreatedProgramCode = "CRT_PGM_C";
        public const string LastUpdatedDate = "LST_UPD_S";
        public const string LastUpdatedUserId = "LST_UPD_UID";
        public const string LastUpdatedProgramCode = "LST_UPD_PGM_C";
    }

    public class CustomerRequestColumnNames
    {
        public const string Identity = "CUS_REQ_I";
        public const string Status = "PRS_STT";
        public const string BusinessEntityName = "BUS_UNT_KEY_CH";
        public const string TypeCode = "REQ_TYP_C";
        public const string ConsumerClassificationType = "CNSM_CLS";
        public const string CreatedDate = "CRT_S";
        public const string CreatedUserId = "CRT_UID";
        public const string CreatedProgramCode = "CRT_PGM_C";
        public const string LastUpdatedDate = "LST_UPD_S";
        public const string LastUpdatedUserId = "LST_UPD_UID";
        public const string LastUpdatedProgramCode = "LST_UPD_PGM_C";
    }

    public class CustomerRequestQueryParameters
    {
        public const string BusinessName = "@BUS_UNT_KEY_CH";
        public const string Identity = "@CUS_REQ_I";
    }

    public class DatabaseConnectionStrings
    {
        public const string Default = "NULL";
    }

    public class EntityNames
    {
        public const string CustomerRequest = "CUS_REQ";
        public const string Stop = "REQ_ETY_OGN";
        public const string ReferenceNumber = "REQ_ETY_REF_NBR";
        public const string Appointment = "REQ_ETY_SCH";
    }

    public class ReferenceNumberColumnNames
    {
        public const string Identity = "REQ_ETY_REF_NBR_I";
        public const string EntityName = "ETY_NM";
        public const string EntityIdentity = "ETY_KEY_I";
        public const string ReferenceNumberType = "SLU_REF_NBR_TYP";
        public const string ReferenceNumberDescription = "REF_NBR_TYP_DSC";
        public const string ReferenceNumber = "REF_NBR";
        public const string CreatedDate = "CRT_S";
        public const string CreatedUserId = "CRT_UID";
        public const string CreatedProgramCode = "CRT_PGM_C";
        public const string LastUpdatedDate = "LST_UPD_S";
        public const string LastUpdatedUserId = "LST_UPD_UID";
        public const string LastUpdatedProgramCode = "LST_UPD_PGM_C";
    }

    public class ReferenceNumberQueryParameters
    {
        public const string ReferenceNumber = "@REF_NBR";
        public const string ReferenceNumberType = "@SLU_REF_NBR_TYP";
    }

    public class StopColumnNames
    {
        public const string Identity = "REQ_ETY_OGN_I";
        public const string EntityName = "ETY_NM";
        public const string EntityIdentity = "ETY_KEY_I";
        public const string RoleType = "SLU_PTR_RL_TYP_C";
        public const string StopNumber = "STP_NBR";
        public const string CustomerAlias = "CUS_SIT_ALS";
        public const string OrganizationName = "OGN_NM";
        public const string AddressLine1 = "ADR_LNE_1";
        public const string AddressLine2 = "ADR_LNE_2";
        public const string AddressCityName = "ADR_CTY_NM";
        public const string AddressStateCode = "ADR_ST_PROV_C";
        public const string AddressCountryCode = "ADR_CRY_C";
        public const string AddressPostalCode = "ADR_PST_C_SRG";
        public const string CreatedDate = "CRT_S";
        public const string CreatedUserId = "CRT_UID";
        public const string CreatedProgramCode = "CRT_PGM_C";
        public const string LastUpdatedDate = "LST_UPD_S";
        public const string LastUpdatedUserId = "LST_UPD_UID";
        public const string LastUpdatedProgramCode = "LST_UPD_PGM_C";
    }

    public class StopQueryParameters
    {
        public const string Identity = "REQ_ETY_OGN_I";
    }
}
