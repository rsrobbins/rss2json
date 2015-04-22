using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RssToJson.App_Code
{
    /// <summary>
    /// RssSkipDays
    /// </summary>
    [Serializable]
    public class RssSkipDays
    {
        private List<string> _days;

        /// <summary>
        /// Gets or sets the days.
        /// </summary>
        /// <value>The days.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists"), XmlElement("day")]
        public List<string> Days
        {
            get 
            { 
                return _days; 
            }

            set 
            { 
                _days = value; 
            }
        }
    }
}
