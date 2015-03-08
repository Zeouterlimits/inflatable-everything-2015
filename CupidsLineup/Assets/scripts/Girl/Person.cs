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
		
	public override bool Equals(System.Object person) {
		if (person == null) {
			return false;
		} else if (this.ToString() == person.ToString()) {
			return true;
		} else {
			return false;
		}
	}

    //Note to future selves, this isn't performant, and it should be changed if we make any of the fields from ToString dynamic.
	public override int GetHashCode ()
	{
		return this.ToString().GetHashCode ();
	}

	public override string ToString () {
		return string.Format ("{{\"personName\":\"{0}\", \"head\":{1}, \"body\":{2}, \"legs\":{3}, \"other\":{4}, \"description\":\"{5}\"}}",
		                      this.personName, this.head, this.body,
		                      this.legs, this.other, this.description);
	}
}

