﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;






namespace HsCentralServiceWeb._sys.hubs
{
	public class HubConnectionHandler<TIdentification>
	{

		private readonly Func<HubCallerContext, TIdentification> _getIdentificationFunc;

		public HubConnectionHandler(IHubContext context, Func<HubCallerContext, TIdentification> getIdentificationFunc)
		{
			Context = context;
			_getIdentificationFunc = getIdentificationFunc;
		}

		public IEnumerable<HubConnection> CurrentConnections => Connections.Values;
		private IHubContext Context { get; }
		private Dictionary<TIdentification, HubConnection> Connections { get; } = new Dictionary<TIdentification, HubConnection>();


		public dynamic GetConnection(TIdentification identification)
		{
			lock (this)
			{
				HubConnection connection;
				if(!Connections.TryGetValue(identification, out connection))
					return null;

				return Context.Clients.Clients(connection.EstablishedConnections.ToList());
			}
		}

		public void Connected(HubCallerContext hc)
		{
			lock (this)
			{
				HubConnection connection = GetOrCreate_ClientConnection(hc);
				connection.EstablishedConnections.Add(hc.ConnectionId);
			}
		}

		public void Reconnected(HubCallerContext hc)
		{
			lock (this)
			{
				HubConnection connection = GetOrCreate_ClientConnection(hc);
				connection.EstablishedConnections.Add(hc.ConnectionId);
			}
		}

		public void Disconnected(HubCallerContext hc)
		{
			lock (this)
			{
				HubConnection connection = Connections.Values.FirstOrDefault(x => x.EstablishedConnections.Contains(hc.ConnectionId));
				if (connection == null)
					return;

				connection.EstablishedConnections.Remove(hc.ConnectionId);
				if (connection.EstablishedConnections.Count == 0)
					Connections.Remove(connection.Identification);
			}
		}

		private HubConnection GetOrCreate_ClientConnection(HubCallerContext context)
		{
			TIdentification identification = _getIdentificationFunc(context);
			HubConnection connection;
			if (!Connections.TryGetValue(identification, out connection))
			{
				connection = new HubConnection(identification);
				Connections.Add(identification, connection);
			}
			return connection;
		}



		public class HubConnection
		{
			public HubConnection(TIdentification identification)
			{
				Identification = identification;
				ConnectionStart = DateTime.Now;
			}


			#region Overrides/Interfaces
			public override string ToString()
			{
				return Identification.ToString();
			}
			#endregion


			public TIdentification Identification { get; }
			public DateTime ConnectionStart { get; }
			public HashSet<string> EstablishedConnections { get; } = new HashSet<string>();
		}
	}
}