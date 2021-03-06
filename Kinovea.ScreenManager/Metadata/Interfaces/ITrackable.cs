﻿#region License
/*
Copyright © Joan Charmant 2012.
jcharmant@gmail.com 
 
This file is part of Kinovea.

Kinovea is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License version 2 
as published by the Free Software Foundation.

Kinovea is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Kinovea. If not, see http://www.gnu.org/licenses/.
*/
#endregion
using System;
using System.Collections.Generic;
using System.Drawing;
using Kinovea.Services;

namespace Kinovea.ScreenManager
{
    public interface ITrackable
    {
        Guid Id { get; }
        string Name { get; }
        Color Color { get; }

        TrackingProfile CustomTrackingProfile { get; }
        
        Dictionary<string, PointF> GetTrackablePoints();
        void SetTracking(bool tracking);

        /// <summary>
        /// Called by the trackability manager after a Track() call.
        /// The value of the trackable point should be updated inside the drawing so the 
        /// drawing reflects the new coordinate.
        /// </summary>
        void SetTrackablePointValue(string name, PointF value);
        
        event EventHandler<TrackablePointMovedEventArgs> TrackablePointMoved;
    }
}
