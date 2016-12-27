﻿// Copyright (c) 2016 All rights reserved Christian Sack
// <author>Christian Sack</author>
// <email>christian@sack.at</email>
// <website>christian.sack.at</website>
// <date>2016-12-20</date>

using System;
using System.Collections.Generic;
using System.Linq;
using HsCentralServiceWeb._dbs.hsserver.centralservicedb.rows;
using HsCentralServiceWebInterfacesClient.steadyConnection.hubs.ringDistribution;
using HsCentralServiceWebInterfacesClient.steadyConnection.hubs.ringDistribution.newRingAvailableArgs;
using HsCentralServiceWebInterfacesClient.steadyConnection.hubs.ringDistribution.playerDataArgs;






namespace HsCentralServiceWeb._sys.hubs.ringDistribution
{
	public class RingDistributionHubModule
	{
		public IEnumerable<RemoteInstance> ConnectedClients => RingDistributionHub.ConnectionHandler.CurrentConnections.Select(x => x.Identification).OrderBy(ord => ord.RemoteUser.RemoteComputer.Name);

		public IEnumerable<RemoteInstance> DisconnectedClients
		{
			get
			{
				var connectedOnes = ConnectedClients.ToArray();
				return Sys.Data.CentralService.RemoteInstances.Where(x => !connectedOnes.Contains(x)).OrderBy(x => x.RemoteUser.RemoteComputer.Name);
			}
		}

		public void OnNewRingAvailable(RemoteInstance client, NewRingAvailableArgs args)
		{
			dynamic computerConnection = RingDistributionHub.ConnectionHandler.GetConnection(client);
			if (computerConnection == null)
				return;
			computerConnection.Invoke(nameof(IRingDistributionHubProtocol.NewRingAvailable), args);
		}

		public void OnPlayerDataRequested(RemoteInstance client, PlayerDataRequestArgs args)
		{
			dynamic computerConnection = RingDistributionHub.ConnectionHandler.GetConnection(client);
			if (computerConnection == null)
				return;
			computerConnection.Invoke(nameof(IRingDistributionHubProtocol.PlayerDataRequested), args);
		}
	}
}