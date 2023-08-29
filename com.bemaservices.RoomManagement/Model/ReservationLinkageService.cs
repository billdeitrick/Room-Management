﻿// <copyright>
// Copyright by BEMA Software Services
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System.Collections.Generic;
using System.Linq;

using Rock;
using Rock.Data;

namespace com.bemaservices.RoomManagement.Model
{
    /// <summary>
    /// Class ReservationLinkageService.
    /// Implements the <see cref="Rock.Data.Service{com.bemaservices.RoomManagement.Model.ReservationLinkage}" />
    /// </summary>
    /// <seealso cref="Rock.Data.Service{com.bemaservices.RoomManagement.Model.ReservationLinkage}" />
    public class ReservationLinkageService : Service<ReservationLinkage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationLinkageService" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ReservationLinkageService( RockContext context ) : base( context ) { }
    }
}
