// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.RoleService
// Assembly: FlightBoard.Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 865BA1F4-EA8F-4787-AA28-3D15C05E7A78
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Service.dll

using FlightBoard.Core.Utilities;
using FlightBoard.Data;
using System.Data.Entity;

namespace FlightBoard.Service.Business
{
    public class RoleService : BusinessServiceBase<fb_Roles>
    {
        //private static RoleService defaultInstance = new RoleService((DbContext)ServiceFactory<FlightBoardEntities>.get_Instance());

        //public static RoleService Default
        //{
        //    get
        //    {
        //        return RoleService.defaultInstance;
        //    }
        //}

        //public RoleService()
        //{
        //}

        //public RoleService(Repository<fb_Roles> repository)
        //    : base(repository)
        //{
        //}

        public RoleService(DbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
