using System;
using System.Xml.Serialization;
using UnityEngine;

		public class Person
		{
			[XmlAttribute("personName")]
			public String personName;
			[XmlElement("head")]
			public int head = 0;
			[XmlElement("body")]
			public int body = 0;
			[XmlElement("legs")]
			public int legs = 0;
			[XmlElement("other")]
			public int other = 0;
			[XmlElement("description")]
			public String description;
			[XmlElement("feedItems")]
			public String[] feedItems;
		}

