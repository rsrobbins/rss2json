using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RssToJson.App_Code
{
    /// <summary>
    ///  RssTextInput class
    /// </summary>
    [Serializable]
    public class RssTextInput
    {
        private string _title;
        private string _description;
        private string _name;
        private string _link;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [XmlElement("description")]
        public string Description
        {
            get 
            { 
                return _description; 
            }

            set 
            { 
                _description = value; 
            }
        }

        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        /// <value>The link.</value>
        [XmlElement("link")]
        public string Link
        {
            get
            {
                return _link;
            }

            set
            {
                _link = value;
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [XmlElement("name")]
        public string Name
        {
            get 
            {
                return _name; 
            }

            set
            {
                _name = value; 
            }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [XmlElement("title")]
        public string Title
        {
            get 
            {
                return _title; 
            }

            set
            { 
                _title = value; 
            }
        }
    }
}
