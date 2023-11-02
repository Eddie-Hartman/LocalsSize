using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace DataProject.Data
{
    [PrimaryKey(nameof(StateCode), nameof(CountyCode))]
    public class CountyLookup
    {
        [Description("State Code")]
        public int StateCode { get; set; }
        [Description("County Code")]
        public int CountyCode { get; set; }
        [Description("County Name")]
        public string CountyName { get; set; }

        public CountyLookup(int stateCode, int countyCode, string countyName)
        {
            StateCode = stateCode;
            CountyCode = countyCode;
            CountyName = countyName;
        }
    }
}
