
using Lib.Web.Mvc.JQuery.JqGrid;
using System;

namespace FlightBoard.Web.Helpers
{
    public class JqGridHelper
    {
        public static JqGridResponse createJQGridResponse(int totalRecordsCount, JqGridRequest request)
        {
            JqGridResponse jqGridResponse = new JqGridResponse(false);
            //jqGridResponse.set_TotalPagesCount((int)Math.Ceiling((double)totalRecordsCount / (double)request.get_RecordsCount()));
            //jqGridResponse.set_PageIndex(request.get_PageIndex());
            //jqGridResponse.set_TotalRecordsCount(totalRecordsCount);
            return jqGridResponse;
        }
    }
}
