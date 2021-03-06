﻿// This file has been autogenerated from a class added in the UI designer.

using System.Collections.Generic;
using CoreLocation;

namespace SpaceAppNative.iOS
{
	static class MapService
	{
		public static List<BasicMapAnnotation> Pois = new List<BasicMapAnnotation> ();
		public static BasicMapAnnotation Example1 = new BasicMapAnnotation (new CLLocationCoordinate2D (39.3502124, -0.5570263), "Fire confirmed", "Picasent, Valencia");
		public static BasicMapAnnotation Example2 = new BasicMapAnnotation (new CLLocationCoordinate2D (39.3099083, -0.5800804), "Fire alert", "El Tello, Valencia");

		static MapService ()
		{
			Pois.Add (Example1);
			Pois.Add (Example2);
			Pois.Add (new BasicMapAnnotation (new CLLocationCoordinate2D (39.1538723, -0.3844146), "Fire confirmed", "Corbera, Valencia"));
			Pois.Add (new BasicMapAnnotation (new CLLocationCoordinate2D (39.155575, -0.6548395), "Fire alert", "Port de Tous, Valencia"));
			Pois.Add (new BasicMapAnnotation (new CLLocationCoordinate2D (39.2741663, -0.8576286), "Fire alert", "Dos Aguas, Valencia"));
		}
	}

}
