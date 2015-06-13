// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.BatchService
// Assembly: FlightBoard.Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 865BA1F4-EA8F-4787-AA28-3D15C05E7A78
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Service.dll

using FlightBoard.Core.Utilities;
using FlightBoard.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FlightBoard.Service.Business
{
    public class BatchService : BusinessServiceBase<fb_Batches>
    {
        //private static BatchService defaultInstance = new BatchService((DbContext)ServiceFactory<FlightBoardEntities>.get_Instance());

        //public static BatchService Default
        //{
        //    get
        //    {
        //        return BatchService.defaultInstance;
        //    }
        //}

        //public BatchService()
        //{
        //}

        //public BatchService(Repository<fb_Batches> repository)
        //    : base(repository)
        //{
        //}

        //public BatchService(DbContext dbContext)
        //    : base(dbContext)
        //{
        //}

        //public void GetBatchByID(int BatchID)
        //{
        //    fb_Batches entity = Enumerable.FirstOrDefault<fb_Batches>(Enumerable.Where<fb_Batches>(Enumerable.AsEnumerable<fb_Batches>((IEnumerable<fb_Batches>)new FlightBoardEntities().get_fb_Batches()), (Func<fb_Batches, bool>)(b => b.get_ID() == BatchID)));
        //    if (entity == null)
        //        return;
        //    this.Delete(entity, true);
        //}
    }
}
