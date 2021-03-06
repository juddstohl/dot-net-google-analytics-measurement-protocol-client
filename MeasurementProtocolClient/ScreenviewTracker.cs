﻿using MeasurementProtocolClient.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;

namespace MeasurementProtocolClient
{
    public class ScreenviewTracker : Tracker
    {
        public ScreenviewTracker(string trackingId, string clientId)
            : base(trackingId, clientId)
        { }

        public override TrackerParameters.HitTypes HitType
        {
            get { return TrackerParameters.HitTypes.screenview ; }
        }
    }
}