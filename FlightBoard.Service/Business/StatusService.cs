// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.StatusService
// Assembly: FlightBoard.Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 865BA1F4-EA8F-4787-AA28-3D15C05E7A78
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Service.dll

using FlightBoard.Core.Utilities;
using FlightBoard.Data;
using System.Data.Entity;

namespace FlightBoard.Service.Business
{
    public class StatusService : BusinessServiceBase<fb_status>
    {
        //private static StatusService defaultInstance = new StatusService((DbContext)ServiceFactory<FlightBoardEntities>.Instance);

        //public static StatusService Default
        //{
        //    get
        //    {
        //        return StatusService.defaultInstance;
        //    }
        //}

        //public StatusService()
        //{
        //}

        //public StatusService(Repository<fb_status> repository)
        //    : base(repository)
        //{
        //}

        public StatusService(DbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
