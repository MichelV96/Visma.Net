﻿using ONIT.VismaNetApi.Models;


namespace ONIT.VismaNetApi.Lib.Data
{
    public class SubaccountData : BasePaginatedCrudDataClass<Subaccount>
    {
        public SubaccountData(VismaNetAuthorization auth) : base(auth)
        {
            ApiControllerUri = VismaNetControllers.Subaccount;
        }
    }
}
