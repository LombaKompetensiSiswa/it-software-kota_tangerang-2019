﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LKS_Kota_Tangerang_2019_Ikhsan_Maulana
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LKS Kota Tangerang 2019")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDetailorder(Detailorder instance);
    partial void UpdateDetailorder(Detailorder instance);
    partial void DeleteDetailorder(Detailorder instance);
    partial void InsertMsmenu(Msmenu instance);
    partial void UpdateMsmenu(Msmenu instance);
    partial void DeleteMsmenu(Msmenu instance);
    partial void InsertHeaderorder(Headerorder instance);
    partial void UpdateHeaderorder(Headerorder instance);
    partial void DeleteHeaderorder(Headerorder instance);
    partial void InsertMsemployee(Msemployee instance);
    partial void UpdateMsemployee(Msemployee instance);
    partial void DeleteMsemployee(Msemployee instance);
    partial void InsertMsmember(Msmember instance);
    partial void UpdateMsmember(Msmember instance);
    partial void DeleteMsmember(Msmember instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::LKS_Kota_Tangerang_2019_Ikhsan_Maulana.Properties.Settings.Default.LKS_Kota_Tangerang_2019ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Detailorder> Detailorders
		{
			get
			{
				return this.GetTable<Detailorder>();
			}
		}
		
		public System.Data.Linq.Table<Msmenu> Msmenus
		{
			get
			{
				return this.GetTable<Msmenu>();
			}
		}
		
		public System.Data.Linq.Table<Headerorder> Headerorders
		{
			get
			{
				return this.GetTable<Headerorder>();
			}
		}
		
		public System.Data.Linq.Table<Msemployee> Msemployees
		{
			get
			{
				return this.GetTable<Msemployee>();
			}
		}
		
		public System.Data.Linq.Table<Msmember> Msmembers
		{
			get
			{
				return this.GetTable<Msmember>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Detailorder")]
	public partial class Detailorder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Detailid;
		
		private string _Orderid;
		
		private int _Menuid;
		
		private int _Qty;
		
		private int _Price;
		
		private string _Status;
		
		private EntityRef<Msmenu> _Msmenu;
		
		private EntityRef<Headerorder> _Headerorder;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDetailidChanging(int value);
    partial void OnDetailidChanged();
    partial void OnOrderidChanging(string value);
    partial void OnOrderidChanged();
    partial void OnMenuidChanging(int value);
    partial void OnMenuidChanged();
    partial void OnQtyChanging(int value);
    partial void OnQtyChanged();
    partial void OnPriceChanging(int value);
    partial void OnPriceChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    #endregion
		
		public Detailorder()
		{
			this._Msmenu = default(EntityRef<Msmenu>);
			this._Headerorder = default(EntityRef<Headerorder>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Detailid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Detailid
		{
			get
			{
				return this._Detailid;
			}
			set
			{
				if ((this._Detailid != value))
				{
					this.OnDetailidChanging(value);
					this.SendPropertyChanging();
					this._Detailid = value;
					this.SendPropertyChanged("Detailid");
					this.OnDetailidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Orderid", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Orderid
		{
			get
			{
				return this._Orderid;
			}
			set
			{
				if ((this._Orderid != value))
				{
					if (this._Headerorder.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderidChanging(value);
					this.SendPropertyChanging();
					this._Orderid = value;
					this.SendPropertyChanged("Orderid");
					this.OnOrderidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Menuid", DbType="Int NOT NULL")]
		public int Menuid
		{
			get
			{
				return this._Menuid;
			}
			set
			{
				if ((this._Menuid != value))
				{
					if (this._Msmenu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMenuidChanging(value);
					this.SendPropertyChanging();
					this._Menuid = value;
					this.SendPropertyChanged("Menuid");
					this.OnMenuidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qty", DbType="Int NOT NULL")]
		public int Qty
		{
			get
			{
				return this._Qty;
			}
			set
			{
				if ((this._Qty != value))
				{
					this.OnQtyChanging(value);
					this.SendPropertyChanging();
					this._Qty = value;
					this.SendPropertyChanged("Qty");
					this.OnQtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int NOT NULL")]
		public int Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Msmenu_Detailorder", Storage="_Msmenu", ThisKey="Menuid", OtherKey="MenuID", IsForeignKey=true)]
		public Msmenu Msmenu
		{
			get
			{
				return this._Msmenu.Entity;
			}
			set
			{
				Msmenu previousValue = this._Msmenu.Entity;
				if (((previousValue != value) 
							|| (this._Msmenu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Msmenu.Entity = null;
						previousValue.Detailorders.Remove(this);
					}
					this._Msmenu.Entity = value;
					if ((value != null))
					{
						value.Detailorders.Add(this);
						this._Menuid = value.MenuID;
					}
					else
					{
						this._Menuid = default(int);
					}
					this.SendPropertyChanged("Msmenu");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Headerorder_Detailorder", Storage="_Headerorder", ThisKey="Orderid", OtherKey="OrderID", IsForeignKey=true)]
		public Headerorder Headerorder
		{
			get
			{
				return this._Headerorder.Entity;
			}
			set
			{
				Headerorder previousValue = this._Headerorder.Entity;
				if (((previousValue != value) 
							|| (this._Headerorder.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Headerorder.Entity = null;
						previousValue.Detailorders.Remove(this);
					}
					this._Headerorder.Entity = value;
					if ((value != null))
					{
						value.Detailorders.Add(this);
						this._Orderid = value.OrderID;
					}
					else
					{
						this._Orderid = default(string);
					}
					this.SendPropertyChanged("Headerorder");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Msmenu")]
	public partial class Msmenu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MenuID;
		
		private string _Name;
		
		private int _Price;
		
		private string _Photo;
		
		private EntitySet<Detailorder> _Detailorders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMenuIDChanging(int value);
    partial void OnMenuIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPriceChanging(int value);
    partial void OnPriceChanged();
    partial void OnPhotoChanging(string value);
    partial void OnPhotoChanged();
    #endregion
		
		public Msmenu()
		{
			this._Detailorders = new EntitySet<Detailorder>(new Action<Detailorder>(this.attach_Detailorders), new Action<Detailorder>(this.detach_Detailorders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MenuID
		{
			get
			{
				return this._MenuID;
			}
			set
			{
				if ((this._MenuID != value))
				{
					this.OnMenuIDChanging(value);
					this.SendPropertyChanging();
					this._MenuID = value;
					this.SendPropertyChanged("MenuID");
					this.OnMenuIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int NOT NULL")]
		public int Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this.OnPhotoChanging(value);
					this.SendPropertyChanging();
					this._Photo = value;
					this.SendPropertyChanged("Photo");
					this.OnPhotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Msmenu_Detailorder", Storage="_Detailorders", ThisKey="MenuID", OtherKey="Menuid")]
		public EntitySet<Detailorder> Detailorders
		{
			get
			{
				return this._Detailorders;
			}
			set
			{
				this._Detailorders.Assign(value);
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
		
		private void attach_Detailorders(Detailorder entity)
		{
			this.SendPropertyChanging();
			entity.Msmenu = this;
		}
		
		private void detach_Detailorders(Detailorder entity)
		{
			this.SendPropertyChanging();
			entity.Msmenu = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Headerorder")]
	public partial class Headerorder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _OrderID;
		
		private string _Employeeid;
		
		private string _Memberid;
		
		private System.DateTime _Date;
		
		private string _Payment;
		
		private string _bank;
		
		private string _CardNumber;
		
		private EntitySet<Detailorder> _Detailorders;
		
		private EntityRef<Msemployee> _Msemployee;
		
		private EntityRef<Msmember> _Msmember;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(string value);
    partial void OnOrderIDChanged();
    partial void OnEmployeeidChanging(string value);
    partial void OnEmployeeidChanged();
    partial void OnMemberidChanging(string value);
    partial void OnMemberidChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnPaymentChanging(string value);
    partial void OnPaymentChanged();
    partial void OnbankChanging(string value);
    partial void OnbankChanged();
    partial void OnCardNumberChanging(string value);
    partial void OnCardNumberChanged();
    #endregion
		
		public Headerorder()
		{
			this._Detailorders = new EntitySet<Detailorder>(new Action<Detailorder>(this.attach_Detailorders), new Action<Detailorder>(this.detach_Detailorders));
			this._Msemployee = default(EntityRef<Msemployee>);
			this._Msmember = default(EntityRef<Msmember>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employeeid", DbType="NChar(6) NOT NULL", CanBeNull=false)]
		public string Employeeid
		{
			get
			{
				return this._Employeeid;
			}
			set
			{
				if ((this._Employeeid != value))
				{
					if (this._Msemployee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeidChanging(value);
					this.SendPropertyChanging();
					this._Employeeid = value;
					this.SendPropertyChanged("Employeeid");
					this.OnEmployeeidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Memberid", DbType="NChar(8) NOT NULL", CanBeNull=false)]
		public string Memberid
		{
			get
			{
				return this._Memberid;
			}
			set
			{
				if ((this._Memberid != value))
				{
					if (this._Msmember.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMemberidChanging(value);
					this.SendPropertyChanging();
					this._Memberid = value;
					this.SendPropertyChanged("Memberid");
					this.OnMemberidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Payment", DbType="NVarChar(50)")]
		public string Payment
		{
			get
			{
				return this._Payment;
			}
			set
			{
				if ((this._Payment != value))
				{
					this.OnPaymentChanging(value);
					this.SendPropertyChanging();
					this._Payment = value;
					this.SendPropertyChanged("Payment");
					this.OnPaymentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bank", DbType="NVarChar(50)")]
		public string bank
		{
			get
			{
				return this._bank;
			}
			set
			{
				if ((this._bank != value))
				{
					this.OnbankChanging(value);
					this.SendPropertyChanging();
					this._bank = value;
					this.SendPropertyChanged("bank");
					this.OnbankChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardNumber", DbType="VarChar(10)")]
		public string CardNumber
		{
			get
			{
				return this._CardNumber;
			}
			set
			{
				if ((this._CardNumber != value))
				{
					this.OnCardNumberChanging(value);
					this.SendPropertyChanging();
					this._CardNumber = value;
					this.SendPropertyChanged("CardNumber");
					this.OnCardNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Headerorder_Detailorder", Storage="_Detailorders", ThisKey="OrderID", OtherKey="Orderid")]
		public EntitySet<Detailorder> Detailorders
		{
			get
			{
				return this._Detailorders;
			}
			set
			{
				this._Detailorders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Msemployee_Headerorder", Storage="_Msemployee", ThisKey="Employeeid", OtherKey="EmployeeID", IsForeignKey=true)]
		public Msemployee Msemployee
		{
			get
			{
				return this._Msemployee.Entity;
			}
			set
			{
				Msemployee previousValue = this._Msemployee.Entity;
				if (((previousValue != value) 
							|| (this._Msemployee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Msemployee.Entity = null;
						previousValue.Headerorders.Remove(this);
					}
					this._Msemployee.Entity = value;
					if ((value != null))
					{
						value.Headerorders.Add(this);
						this._Employeeid = value.EmployeeID;
					}
					else
					{
						this._Employeeid = default(string);
					}
					this.SendPropertyChanged("Msemployee");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Msmember_Headerorder", Storage="_Msmember", ThisKey="Memberid", OtherKey="MemberID", IsForeignKey=true)]
		public Msmember Msmember
		{
			get
			{
				return this._Msmember.Entity;
			}
			set
			{
				Msmember previousValue = this._Msmember.Entity;
				if (((previousValue != value) 
							|| (this._Msmember.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Msmember.Entity = null;
						previousValue.Headerorders.Remove(this);
					}
					this._Msmember.Entity = value;
					if ((value != null))
					{
						value.Headerorders.Add(this);
						this._Memberid = value.MemberID;
					}
					else
					{
						this._Memberid = default(string);
					}
					this.SendPropertyChanged("Msmember");
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
		
		private void attach_Detailorders(Detailorder entity)
		{
			this.SendPropertyChanging();
			entity.Headerorder = this;
		}
		
		private void detach_Detailorders(Detailorder entity)
		{
			this.SendPropertyChanging();
			entity.Headerorder = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Msemployee")]
	public partial class Msemployee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _EmployeeID;
		
		private string _Name;
		
		private string _Email;
		
		private string _Password;
		
		private string _Handphone;
		
		private string _Position;
		
		private EntitySet<Headerorder> _Headerorders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIDChanging(string value);
    partial void OnEmployeeIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnHandphoneChanging(string value);
    partial void OnHandphoneChanged();
    partial void OnPositionChanging(string value);
    partial void OnPositionChanged();
    #endregion
		
		public Msemployee()
		{
			this._Headerorders = new EntitySet<Headerorder>(new Action<Headerorder>(this.attach_Headerorders), new Action<Headerorder>(this.detach_Headerorders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="NChar(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Handphone", DbType="NVarChar(13) NOT NULL", CanBeNull=false)]
		public string Handphone
		{
			get
			{
				return this._Handphone;
			}
			set
			{
				if ((this._Handphone != value))
				{
					this.OnHandphoneChanging(value);
					this.SendPropertyChanging();
					this._Handphone = value;
					this.SendPropertyChanged("Handphone");
					this.OnHandphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this.OnPositionChanging(value);
					this.SendPropertyChanging();
					this._Position = value;
					this.SendPropertyChanged("Position");
					this.OnPositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Msemployee_Headerorder", Storage="_Headerorders", ThisKey="EmployeeID", OtherKey="Employeeid")]
		public EntitySet<Headerorder> Headerorders
		{
			get
			{
				return this._Headerorders;
			}
			set
			{
				this._Headerorders.Assign(value);
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
		
		private void attach_Headerorders(Headerorder entity)
		{
			this.SendPropertyChanging();
			entity.Msemployee = this;
		}
		
		private void detach_Headerorders(Headerorder entity)
		{
			this.SendPropertyChanging();
			entity.Msemployee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Msmember")]
	public partial class Msmember : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MemberID;
		
		private string _Name;
		
		private string _Email;
		
		private string _Handphone;
		
		private System.DateTime _JoinDate;
		
		private EntitySet<Headerorder> _Headerorders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMemberIDChanging(string value);
    partial void OnMemberIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnHandphoneChanging(string value);
    partial void OnHandphoneChanged();
    partial void OnJoinDateChanging(System.DateTime value);
    partial void OnJoinDateChanged();
    #endregion
		
		public Msmember()
		{
			this._Headerorders = new EntitySet<Headerorder>(new Action<Headerorder>(this.attach_Headerorders), new Action<Headerorder>(this.detach_Headerorders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberID", DbType="NChar(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MemberID
		{
			get
			{
				return this._MemberID;
			}
			set
			{
				if ((this._MemberID != value))
				{
					this.OnMemberIDChanging(value);
					this.SendPropertyChanging();
					this._MemberID = value;
					this.SendPropertyChanged("MemberID");
					this.OnMemberIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Handphone", DbType="NVarChar(13) NOT NULL", CanBeNull=false)]
		public string Handphone
		{
			get
			{
				return this._Handphone;
			}
			set
			{
				if ((this._Handphone != value))
				{
					this.OnHandphoneChanging(value);
					this.SendPropertyChanging();
					this._Handphone = value;
					this.SendPropertyChanged("Handphone");
					this.OnHandphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JoinDate", DbType="Date NOT NULL")]
		public System.DateTime JoinDate
		{
			get
			{
				return this._JoinDate;
			}
			set
			{
				if ((this._JoinDate != value))
				{
					this.OnJoinDateChanging(value);
					this.SendPropertyChanging();
					this._JoinDate = value;
					this.SendPropertyChanged("JoinDate");
					this.OnJoinDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Msmember_Headerorder", Storage="_Headerorders", ThisKey="MemberID", OtherKey="Memberid")]
		public EntitySet<Headerorder> Headerorders
		{
			get
			{
				return this._Headerorders;
			}
			set
			{
				this._Headerorders.Assign(value);
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
		
		private void attach_Headerorders(Headerorder entity)
		{
			this.SendPropertyChanging();
			entity.Msmember = this;
		}
		
		private void detach_Headerorders(Headerorder entity)
		{
			this.SendPropertyChanging();
			entity.Msmember = null;
		}
	}
}
#pragma warning restore 1591
