// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.DataModels.FlighBoardConfigureListModel
// Assembly: FlightBoard.Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 865BA1F4-EA8F-4787-AA28-3D15C05E7A78
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Service.dll

using System;

namespace FlightBoard.Service.Business.DataModels
{
    public class FlighBoardConfigureListModel
    {
        public int ID { get; set; }

        public int DeviceID { get; set; }

        public string DeviceName { get; set; }

        public int? PrepAreaId { get; set; }

        public string PrepAreaName { get; set; }

        public int TemplateID { get; set; }

        public string TransitionTime { get; set; }

        public DateTime? EventStartDate { get; set; }

        public DateTime? EventEndDate { get; set; }

        public DateTime? ProductionFrom { get; set; }

        public DateTime? ProductionTo { get; set; }

        public int? EventId { get; set; }

        public string EventName { get; set; }
    }
}
