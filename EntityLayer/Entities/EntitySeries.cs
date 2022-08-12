using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    internal class EntitySeries
    {
        private int seriesid;
        private string seriesname;
        private string seriescountry;
        private string seriesdetails;
        private string seriesimage;
        private string seriesseasoncount;
        private string seriestotalepisode;
        private int categoryid;

        public int Seriesid { get => seriesid; set => seriesid = value; }
        public string Seriesname { get => seriesname; set => seriesname = value; }
        public string Seriescountry { get => seriescountry; set => seriescountry = value; }
        public string Seriesdetails { get => seriesdetails; set => seriesdetails = value; }
        public string Seriesimage { get => seriesimage; set => seriesimage = value; }
        public string Seriesseasoncount { get => seriesseasoncount; set => seriesseasoncount = value; }
        public string Seriestotalepisode { get => seriestotalepisode; set => seriestotalepisode = value; }
        public int Categoryid { get => categoryid; set => categoryid = value; }
    }
}
