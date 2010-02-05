﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventarios.Core
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="Almacen")]
	public partial class AlmacenORMDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCliente(Cliente instance);
    partial void UpdateCliente(Cliente instance);
    partial void DeleteCliente(Cliente instance);
    #endregion
		
		public AlmacenORMDataContext() : 
				base(global::Inventarios.Core.Properties.Settings.Default.AlmacenConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AlmacenORMDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AlmacenORMDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AlmacenORMDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AlmacenORMDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cliente> Clientes
		{
			get
			{
				return this.GetTable<Cliente>();
			}
		}
	}
	
	[Table(Name="dbo.Clientes")]
	public partial class Cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _NoControl;
		
		private string _Nombre;
		
		private string _RFC;
		
		private string _Direccion;
		
		private string _Telefono;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNoControlChanging(int value);
    partial void OnNoControlChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnRFCChanging(string value);
    partial void OnRFCChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    #endregion
		
		public Cliente()
		{
			OnCreated();
		}
		
		[Column(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[Column(Storage="_NoControl", DbType="Int NOT NULL")]
		public int NoControl
		{
			get
			{
				return this._NoControl;
			}
			set
			{
				if ((this._NoControl != value))
				{
					this.OnNoControlChanging(value);
					this.SendPropertyChanging();
					this._NoControl = value;
					this.SendPropertyChanged("NoControl");
					this.OnNoControlChanged();
				}
			}
		}
		
		[Column(Storage="_Nombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[Column(Storage="_RFC", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string RFC
		{
			get
			{
				return this._RFC;
			}
			set
			{
				if ((this._RFC != value))
				{
					this.OnRFCChanging(value);
					this.SendPropertyChanging();
					this._RFC = value;
					this.SendPropertyChanged("RFC");
					this.OnRFCChanged();
				}
			}
		}
		
		[Column(Storage="_Direccion", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[Column(Storage="_Telefono", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
