// This file has been autogenerated from a class added in the UI designer.

using CoreLocation;
using MapKit;

namespace SpaceAppNative.iOS
{
	class BasicMapAnnotation : MKAnnotation
	{
		CLLocationCoordinate2D coord;
		string title, subtitle;

		public override CLLocationCoordinate2D Coordinate { get { return coord; } }
		public override void SetCoordinate (CLLocationCoordinate2D value)
		{
			coord = value;
		}
		public override string Title { get { return title; } }
		public override string Subtitle { get { return subtitle; } }
		public BasicMapAnnotation (CLLocationCoordinate2D coordinate, string title, string subtitle)
		{
<<<<<<< HEAD
			this.coord = coordinate; //ewweew //ewwewew
=======
			this.coord = coordinate; //ewweew  rreerere
>>>>>>> c2194b9... gg
			this.title = title;
			this.subtitle = subtitle;
		}
	}

}
