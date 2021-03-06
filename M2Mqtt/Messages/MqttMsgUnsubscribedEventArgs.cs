/*
M2Mqtt - MQTT Client Library for .Net
Copyright (c) 2014, Paolo Patierno, All rights reserved.

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 3.0 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library.
*/

#if (!MF_FRAMEWORK_VERSION_V4_2 && !MF_FRAMEWORK_VERSION_V4_3)
using System;
#else
using Microsoft.SPOT;
#endif

namespace uPLibrary.Networking.M2Mqtt.Messages
{
    /// <summary>
    /// Event Args class for unsubscribed topic
    /// </summary>
    public class MqttMsgUnsubscribedEventArgs : EventArgs
    {
        #region Properties...

        /// <summary>
        /// Message identifier
        /// </summary>
        public ushort MessageId
        {
            get { return this.messageId; }
            internal set { this.messageId = value; }
        }

        #endregion

        // message identifier
        ushort messageId;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="messageId">Message identifier for unsubscribed topic</param>
        public MqttMsgUnsubscribedEventArgs(ushort messageId)
        {
            this.messageId = messageId;
        }
    }
}
