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

namespace ApiDados
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CORPORE_IMO_SOAP")]
	public partial class ImoveisDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertXALGIMOVEL(XALGIMOVEL instance);
    partial void UpdateXALGIMOVEL(XALGIMOVEL instance);
    partial void DeleteXALGIMOVEL(XALGIMOVEL instance);
    #endregion
		
		public ImoveisDataContext() : 
				base(global::ApiDados.Properties.Settings.Default.CORPORE_IMO_SOAPConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ImoveisDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ImoveisDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ImoveisDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ImoveisDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<XALGIMOVEL> XALGIMOVELs
		{
			get
			{
				return this.GetTable<XALGIMOVEL>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.XALGIMOVEL")]
	public partial class XALGIMOVEL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _CODCOLIMOVEL;
		
		private int _CODIMOVEL;
		
		private System.Nullable<short> _IMOVELPROPRIO;
		
		private System.Nullable<decimal> _AREAPRIVATIVA;
		
		private System.Nullable<decimal> _AREACOMUM;
		
		private System.Nullable<decimal> _AREATOTAL;
		
		private System.Nullable<short> _TIPOAREA;
		
		private System.Nullable<decimal> _VALORCONDOMINIO;
		
		private System.Nullable<decimal> _VALORLOCACAOSUGERIDO;
		
		private string _LOCALCHAVES;
		
		private System.Nullable<short> _ACEITANEGOCIACAO;
		
		private System.Nullable<System.DateTime> _DATACADASTRO;
		
		private System.Nullable<decimal> _VALORENCARGOS;
		
		private string _CEP;
		
		private System.Nullable<short> _TIPOLOGRADOURO;
		
		private string _LOGRADOURO;
		
		private string _COMPLEMENTO;
		
		private string _NUMERO;
		
		private string _BAIRRO;
		
		private string _MUNICIPIO;
		
		private string _ESTADO;
		
		private System.Nullable<short> _PAIS;
		
		private string _RECCREATEDBY;
		
		private System.Nullable<System.DateTime> _RECCREATEDON;
		
		private string _RECMODIFIEDBY;
		
		private System.Nullable<System.DateTime> _RECMODIFIEDON;
		
		private System.Nullable<char> _TIPOENDERECO;
		
		private System.Nullable<int> _SITUACAOIMOVEL;
		
		private string _DESCIMOVEL;
		
		private string _HISTSITUACAOIMOVEL;
		
		private string _CODCCUSTO;
		
		private System.Nullable<short> _CODCOLCCUSTO;
		
		private System.Nullable<decimal> _PERCENTPARTADM;
		
		private System.Nullable<short> _CONTROLADOM2;
		
		private System.Nullable<int> _TIPOLOCACAOAREA;
		
		private System.Nullable<decimal> _METROQUADRADOLOCADO;
		
		private System.Nullable<decimal> _METROQUADRADODISPONIVEL;
		
		private System.Nullable<decimal> _METROQUADRADOLOCAVEL;
		
		private System.Nullable<decimal> _METROQUADRADORESERVADO;
		
		private System.Nullable<int> _CODCARTORIO;
		
		private System.Nullable<short> _CODCOLPREFEITURA;
		
		private string _CODPREFEITURA;
		
		private System.Nullable<int> _CODREGIAO;
		
		private System.Nullable<int> _CODTIPOIMOVEL;
		
		private string _LOCALIZACAO;
		
		private System.Nullable<short> _REGULARIZADO;
		
		private System.Nullable<System.DateTime> _DATAAQUISICAO;
		
		private System.Nullable<short> _CODCOLITEMCONTABIL;
		
		private System.Nullable<int> _IDITEMCONTABIL;
		
		private System.Nullable<short> _CODCOLCLASSEVALOR;
		
		private System.Nullable<int> _IDCLASSEVALOR;
		
		private short _INTEGRACAOPORTAIS;
		
		private string _OBSERVACAO;
		
		private System.Nullable<int> _COD_TIPO_IMOVEL;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCODCOLIMOVELChanging(short value);
    partial void OnCODCOLIMOVELChanged();
    partial void OnCODIMOVELChanging(int value);
    partial void OnCODIMOVELChanged();
    partial void OnIMOVELPROPRIOChanging(System.Nullable<short> value);
    partial void OnIMOVELPROPRIOChanged();
    partial void OnAREAPRIVATIVAChanging(System.Nullable<decimal> value);
    partial void OnAREAPRIVATIVAChanged();
    partial void OnAREACOMUMChanging(System.Nullable<decimal> value);
    partial void OnAREACOMUMChanged();
    partial void OnAREATOTALChanging(System.Nullable<decimal> value);
    partial void OnAREATOTALChanged();
    partial void OnTIPOAREAChanging(System.Nullable<short> value);
    partial void OnTIPOAREAChanged();
    partial void OnVALORCONDOMINIOChanging(System.Nullable<decimal> value);
    partial void OnVALORCONDOMINIOChanged();
    partial void OnVALORLOCACAOSUGERIDOChanging(System.Nullable<decimal> value);
    partial void OnVALORLOCACAOSUGERIDOChanged();
    partial void OnLOCALCHAVESChanging(string value);
    partial void OnLOCALCHAVESChanged();
    partial void OnACEITANEGOCIACAOChanging(System.Nullable<short> value);
    partial void OnACEITANEGOCIACAOChanged();
    partial void OnDATACADASTROChanging(System.Nullable<System.DateTime> value);
    partial void OnDATACADASTROChanged();
    partial void OnVALORENCARGOSChanging(System.Nullable<decimal> value);
    partial void OnVALORENCARGOSChanged();
    partial void OnCEPChanging(string value);
    partial void OnCEPChanged();
    partial void OnTIPOLOGRADOUROChanging(System.Nullable<short> value);
    partial void OnTIPOLOGRADOUROChanged();
    partial void OnLOGRADOUROChanging(string value);
    partial void OnLOGRADOUROChanged();
    partial void OnCOMPLEMENTOChanging(string value);
    partial void OnCOMPLEMENTOChanged();
    partial void OnNUMEROChanging(string value);
    partial void OnNUMEROChanged();
    partial void OnBAIRROChanging(string value);
    partial void OnBAIRROChanged();
    partial void OnMUNICIPIOChanging(string value);
    partial void OnMUNICIPIOChanged();
    partial void OnESTADOChanging(string value);
    partial void OnESTADOChanged();
    partial void OnPAISChanging(System.Nullable<short> value);
    partial void OnPAISChanged();
    partial void OnRECCREATEDBYChanging(string value);
    partial void OnRECCREATEDBYChanged();
    partial void OnRECCREATEDONChanging(System.Nullable<System.DateTime> value);
    partial void OnRECCREATEDONChanged();
    partial void OnRECMODIFIEDBYChanging(string value);
    partial void OnRECMODIFIEDBYChanged();
    partial void OnRECMODIFIEDONChanging(System.Nullable<System.DateTime> value);
    partial void OnRECMODIFIEDONChanged();
    partial void OnTIPOENDERECOChanging(System.Nullable<char> value);
    partial void OnTIPOENDERECOChanged();
    partial void OnSITUACAOIMOVELChanging(System.Nullable<int> value);
    partial void OnSITUACAOIMOVELChanged();
    partial void OnDESCIMOVELChanging(string value);
    partial void OnDESCIMOVELChanged();
    partial void OnHISTSITUACAOIMOVELChanging(string value);
    partial void OnHISTSITUACAOIMOVELChanged();
    partial void OnCODCCUSTOChanging(string value);
    partial void OnCODCCUSTOChanged();
    partial void OnCODCOLCCUSTOChanging(System.Nullable<short> value);
    partial void OnCODCOLCCUSTOChanged();
    partial void OnPERCENTPARTADMChanging(System.Nullable<decimal> value);
    partial void OnPERCENTPARTADMChanged();
    partial void OnCONTROLADOM2Changing(System.Nullable<short> value);
    partial void OnCONTROLADOM2Changed();
    partial void OnTIPOLOCACAOAREAChanging(System.Nullable<int> value);
    partial void OnTIPOLOCACAOAREAChanged();
    partial void OnMETROQUADRADOLOCADOChanging(System.Nullable<decimal> value);
    partial void OnMETROQUADRADOLOCADOChanged();
    partial void OnMETROQUADRADODISPONIVELChanging(System.Nullable<decimal> value);
    partial void OnMETROQUADRADODISPONIVELChanged();
    partial void OnMETROQUADRADOLOCAVELChanging(System.Nullable<decimal> value);
    partial void OnMETROQUADRADOLOCAVELChanged();
    partial void OnMETROQUADRADORESERVADOChanging(System.Nullable<decimal> value);
    partial void OnMETROQUADRADORESERVADOChanged();
    partial void OnCODCARTORIOChanging(System.Nullable<int> value);
    partial void OnCODCARTORIOChanged();
    partial void OnCODCOLPREFEITURAChanging(System.Nullable<short> value);
    partial void OnCODCOLPREFEITURAChanged();
    partial void OnCODPREFEITURAChanging(string value);
    partial void OnCODPREFEITURAChanged();
    partial void OnCODREGIAOChanging(System.Nullable<int> value);
    partial void OnCODREGIAOChanged();
    partial void OnCODTIPOIMOVELChanging(System.Nullable<int> value);
    partial void OnCODTIPOIMOVELChanged();
    partial void OnLOCALIZACAOChanging(string value);
    partial void OnLOCALIZACAOChanged();
    partial void OnREGULARIZADOChanging(System.Nullable<short> value);
    partial void OnREGULARIZADOChanged();
    partial void OnDATAAQUISICAOChanging(System.Nullable<System.DateTime> value);
    partial void OnDATAAQUISICAOChanged();
    partial void OnCODCOLITEMCONTABILChanging(System.Nullable<short> value);
    partial void OnCODCOLITEMCONTABILChanged();
    partial void OnIDITEMCONTABILChanging(System.Nullable<int> value);
    partial void OnIDITEMCONTABILChanged();
    partial void OnCODCOLCLASSEVALORChanging(System.Nullable<short> value);
    partial void OnCODCOLCLASSEVALORChanged();
    partial void OnIDCLASSEVALORChanging(System.Nullable<int> value);
    partial void OnIDCLASSEVALORChanged();
    partial void OnINTEGRACAOPORTAISChanging(short value);
    partial void OnINTEGRACAOPORTAISChanged();
    partial void OnOBSERVACAOChanging(string value);
    partial void OnOBSERVACAOChanged();
    partial void OnCOD_TIPO_IMOVELChanging(System.Nullable<int> value);
    partial void OnCOD_TIPO_IMOVELChanged();
    #endregion
		
		public XALGIMOVEL()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODCOLIMOVEL", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short CODCOLIMOVEL
		{
			get
			{
				return this._CODCOLIMOVEL;
			}
			set
			{
				if ((this._CODCOLIMOVEL != value))
				{
					this.OnCODCOLIMOVELChanging(value);
					this.SendPropertyChanging();
					this._CODCOLIMOVEL = value;
					this.SendPropertyChanged("CODCOLIMOVEL");
					this.OnCODCOLIMOVELChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODIMOVEL", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CODIMOVEL
		{
			get
			{
				return this._CODIMOVEL;
			}
			set
			{
				if ((this._CODIMOVEL != value))
				{
					this.OnCODIMOVELChanging(value);
					this.SendPropertyChanging();
					this._CODIMOVEL = value;
					this.SendPropertyChanged("CODIMOVEL");
					this.OnCODIMOVELChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMOVELPROPRIO", DbType="SmallInt")]
		public System.Nullable<short> IMOVELPROPRIO
		{
			get
			{
				return this._IMOVELPROPRIO;
			}
			set
			{
				if ((this._IMOVELPROPRIO != value))
				{
					this.OnIMOVELPROPRIOChanging(value);
					this.SendPropertyChanging();
					this._IMOVELPROPRIO = value;
					this.SendPropertyChanged("IMOVELPROPRIO");
					this.OnIMOVELPROPRIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AREAPRIVATIVA", DbType="Decimal(15,4)")]
		public System.Nullable<decimal> AREAPRIVATIVA
		{
			get
			{
				return this._AREAPRIVATIVA;
			}
			set
			{
				if ((this._AREAPRIVATIVA != value))
				{
					this.OnAREAPRIVATIVAChanging(value);
					this.SendPropertyChanging();
					this._AREAPRIVATIVA = value;
					this.SendPropertyChanged("AREAPRIVATIVA");
					this.OnAREAPRIVATIVAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AREACOMUM", DbType="Decimal(15,4)")]
		public System.Nullable<decimal> AREACOMUM
		{
			get
			{
				return this._AREACOMUM;
			}
			set
			{
				if ((this._AREACOMUM != value))
				{
					this.OnAREACOMUMChanging(value);
					this.SendPropertyChanging();
					this._AREACOMUM = value;
					this.SendPropertyChanged("AREACOMUM");
					this.OnAREACOMUMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AREATOTAL", DbType="Decimal(15,4)")]
		public System.Nullable<decimal> AREATOTAL
		{
			get
			{
				return this._AREATOTAL;
			}
			set
			{
				if ((this._AREATOTAL != value))
				{
					this.OnAREATOTALChanging(value);
					this.SendPropertyChanging();
					this._AREATOTAL = value;
					this.SendPropertyChanged("AREATOTAL");
					this.OnAREATOTALChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIPOAREA", DbType="SmallInt")]
		public System.Nullable<short> TIPOAREA
		{
			get
			{
				return this._TIPOAREA;
			}
			set
			{
				if ((this._TIPOAREA != value))
				{
					this.OnTIPOAREAChanging(value);
					this.SendPropertyChanging();
					this._TIPOAREA = value;
					this.SendPropertyChanged("TIPOAREA");
					this.OnTIPOAREAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VALORCONDOMINIO", DbType="Decimal(15,4)")]
		public System.Nullable<decimal> VALORCONDOMINIO
		{
			get
			{
				return this._VALORCONDOMINIO;
			}
			set
			{
				if ((this._VALORCONDOMINIO != value))
				{
					this.OnVALORCONDOMINIOChanging(value);
					this.SendPropertyChanging();
					this._VALORCONDOMINIO = value;
					this.SendPropertyChanged("VALORCONDOMINIO");
					this.OnVALORCONDOMINIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VALORLOCACAOSUGERIDO", DbType="Decimal(20,8)")]
		public System.Nullable<decimal> VALORLOCACAOSUGERIDO
		{
			get
			{
				return this._VALORLOCACAOSUGERIDO;
			}
			set
			{
				if ((this._VALORLOCACAOSUGERIDO != value))
				{
					this.OnVALORLOCACAOSUGERIDOChanging(value);
					this.SendPropertyChanging();
					this._VALORLOCACAOSUGERIDO = value;
					this.SendPropertyChanged("VALORLOCACAOSUGERIDO");
					this.OnVALORLOCACAOSUGERIDOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOCALCHAVES", DbType="VarChar(50)")]
		public string LOCALCHAVES
		{
			get
			{
				return this._LOCALCHAVES;
			}
			set
			{
				if ((this._LOCALCHAVES != value))
				{
					this.OnLOCALCHAVESChanging(value);
					this.SendPropertyChanging();
					this._LOCALCHAVES = value;
					this.SendPropertyChanged("LOCALCHAVES");
					this.OnLOCALCHAVESChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ACEITANEGOCIACAO", DbType="SmallInt")]
		public System.Nullable<short> ACEITANEGOCIACAO
		{
			get
			{
				return this._ACEITANEGOCIACAO;
			}
			set
			{
				if ((this._ACEITANEGOCIACAO != value))
				{
					this.OnACEITANEGOCIACAOChanging(value);
					this.SendPropertyChanging();
					this._ACEITANEGOCIACAO = value;
					this.SendPropertyChanged("ACEITANEGOCIACAO");
					this.OnACEITANEGOCIACAOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATACADASTRO", DbType="DateTime")]
		public System.Nullable<System.DateTime> DATACADASTRO
		{
			get
			{
				return this._DATACADASTRO;
			}
			set
			{
				if ((this._DATACADASTRO != value))
				{
					this.OnDATACADASTROChanging(value);
					this.SendPropertyChanging();
					this._DATACADASTRO = value;
					this.SendPropertyChanged("DATACADASTRO");
					this.OnDATACADASTROChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VALORENCARGOS", DbType="Decimal(15,4)")]
		public System.Nullable<decimal> VALORENCARGOS
		{
			get
			{
				return this._VALORENCARGOS;
			}
			set
			{
				if ((this._VALORENCARGOS != value))
				{
					this.OnVALORENCARGOSChanging(value);
					this.SendPropertyChanging();
					this._VALORENCARGOS = value;
					this.SendPropertyChanged("VALORENCARGOS");
					this.OnVALORENCARGOSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CEP", DbType="Char(9)")]
		public string CEP
		{
			get
			{
				return this._CEP;
			}
			set
			{
				if ((this._CEP != value))
				{
					this.OnCEPChanging(value);
					this.SendPropertyChanging();
					this._CEP = value;
					this.SendPropertyChanged("CEP");
					this.OnCEPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIPOLOGRADOURO", DbType="SmallInt")]
		public System.Nullable<short> TIPOLOGRADOURO
		{
			get
			{
				return this._TIPOLOGRADOURO;
			}
			set
			{
				if ((this._TIPOLOGRADOURO != value))
				{
					this.OnTIPOLOGRADOUROChanging(value);
					this.SendPropertyChanging();
					this._TIPOLOGRADOURO = value;
					this.SendPropertyChanged("TIPOLOGRADOURO");
					this.OnTIPOLOGRADOUROChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOGRADOURO", DbType="VarChar(100)")]
		public string LOGRADOURO
		{
			get
			{
				return this._LOGRADOURO;
			}
			set
			{
				if ((this._LOGRADOURO != value))
				{
					this.OnLOGRADOUROChanging(value);
					this.SendPropertyChanging();
					this._LOGRADOURO = value;
					this.SendPropertyChanged("LOGRADOURO");
					this.OnLOGRADOUROChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMPLEMENTO", DbType="VarChar(60)")]
		public string COMPLEMENTO
		{
			get
			{
				return this._COMPLEMENTO;
			}
			set
			{
				if ((this._COMPLEMENTO != value))
				{
					this.OnCOMPLEMENTOChanging(value);
					this.SendPropertyChanging();
					this._COMPLEMENTO = value;
					this.SendPropertyChanged("COMPLEMENTO");
					this.OnCOMPLEMENTOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NUMERO", DbType="VarChar(6)")]
		public string NUMERO
		{
			get
			{
				return this._NUMERO;
			}
			set
			{
				if ((this._NUMERO != value))
				{
					this.OnNUMEROChanging(value);
					this.SendPropertyChanging();
					this._NUMERO = value;
					this.SendPropertyChanged("NUMERO");
					this.OnNUMEROChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BAIRRO", DbType="VarChar(80)")]
		public string BAIRRO
		{
			get
			{
				return this._BAIRRO;
			}
			set
			{
				if ((this._BAIRRO != value))
				{
					this.OnBAIRROChanging(value);
					this.SendPropertyChanging();
					this._BAIRRO = value;
					this.SendPropertyChanged("BAIRRO");
					this.OnBAIRROChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MUNICIPIO", DbType="VarChar(20)")]
		public string MUNICIPIO
		{
			get
			{
				return this._MUNICIPIO;
			}
			set
			{
				if ((this._MUNICIPIO != value))
				{
					this.OnMUNICIPIOChanging(value);
					this.SendPropertyChanging();
					this._MUNICIPIO = value;
					this.SendPropertyChanged("MUNICIPIO");
					this.OnMUNICIPIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTADO", DbType="VarChar(2)")]
		public string ESTADO
		{
			get
			{
				return this._ESTADO;
			}
			set
			{
				if ((this._ESTADO != value))
				{
					this.OnESTADOChanging(value);
					this.SendPropertyChanging();
					this._ESTADO = value;
					this.SendPropertyChanged("ESTADO");
					this.OnESTADOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PAIS", DbType="SmallInt")]
		public System.Nullable<short> PAIS
		{
			get
			{
				return this._PAIS;
			}
			set
			{
				if ((this._PAIS != value))
				{
					this.OnPAISChanging(value);
					this.SendPropertyChanging();
					this._PAIS = value;
					this.SendPropertyChanged("PAIS");
					this.OnPAISChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RECCREATEDBY", DbType="VarChar(50)")]
		public string RECCREATEDBY
		{
			get
			{
				return this._RECCREATEDBY;
			}
			set
			{
				if ((this._RECCREATEDBY != value))
				{
					this.OnRECCREATEDBYChanging(value);
					this.SendPropertyChanging();
					this._RECCREATEDBY = value;
					this.SendPropertyChanged("RECCREATEDBY");
					this.OnRECCREATEDBYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RECCREATEDON", DbType="DateTime")]
		public System.Nullable<System.DateTime> RECCREATEDON
		{
			get
			{
				return this._RECCREATEDON;
			}
			set
			{
				if ((this._RECCREATEDON != value))
				{
					this.OnRECCREATEDONChanging(value);
					this.SendPropertyChanging();
					this._RECCREATEDON = value;
					this.SendPropertyChanged("RECCREATEDON");
					this.OnRECCREATEDONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RECMODIFIEDBY", DbType="VarChar(50)")]
		public string RECMODIFIEDBY
		{
			get
			{
				return this._RECMODIFIEDBY;
			}
			set
			{
				if ((this._RECMODIFIEDBY != value))
				{
					this.OnRECMODIFIEDBYChanging(value);
					this.SendPropertyChanging();
					this._RECMODIFIEDBY = value;
					this.SendPropertyChanged("RECMODIFIEDBY");
					this.OnRECMODIFIEDBYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RECMODIFIEDON", DbType="DateTime")]
		public System.Nullable<System.DateTime> RECMODIFIEDON
		{
			get
			{
				return this._RECMODIFIEDON;
			}
			set
			{
				if ((this._RECMODIFIEDON != value))
				{
					this.OnRECMODIFIEDONChanging(value);
					this.SendPropertyChanging();
					this._RECMODIFIEDON = value;
					this.SendPropertyChanged("RECMODIFIEDON");
					this.OnRECMODIFIEDONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIPOENDERECO", DbType="Char(1)")]
		public System.Nullable<char> TIPOENDERECO
		{
			get
			{
				return this._TIPOENDERECO;
			}
			set
			{
				if ((this._TIPOENDERECO != value))
				{
					this.OnTIPOENDERECOChanging(value);
					this.SendPropertyChanging();
					this._TIPOENDERECO = value;
					this.SendPropertyChanged("TIPOENDERECO");
					this.OnTIPOENDERECOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SITUACAOIMOVEL", DbType="Int")]
		public System.Nullable<int> SITUACAOIMOVEL
		{
			get
			{
				return this._SITUACAOIMOVEL;
			}
			set
			{
				if ((this._SITUACAOIMOVEL != value))
				{
					this.OnSITUACAOIMOVELChanging(value);
					this.SendPropertyChanging();
					this._SITUACAOIMOVEL = value;
					this.SendPropertyChanged("SITUACAOIMOVEL");
					this.OnSITUACAOIMOVELChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCIMOVEL", DbType="VarChar(MAX)")]
		public string DESCIMOVEL
		{
			get
			{
				return this._DESCIMOVEL;
			}
			set
			{
				if ((this._DESCIMOVEL != value))
				{
					this.OnDESCIMOVELChanging(value);
					this.SendPropertyChanging();
					this._DESCIMOVEL = value;
					this.SendPropertyChanged("DESCIMOVEL");
					this.OnDESCIMOVELChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HISTSITUACAOIMOVEL", DbType="VarChar(MAX)")]
		public string HISTSITUACAOIMOVEL
		{
			get
			{
				return this._HISTSITUACAOIMOVEL;
			}
			set
			{
				if ((this._HISTSITUACAOIMOVEL != value))
				{
					this.OnHISTSITUACAOIMOVELChanging(value);
					this.SendPropertyChanging();
					this._HISTSITUACAOIMOVEL = value;
					this.SendPropertyChanged("HISTSITUACAOIMOVEL");
					this.OnHISTSITUACAOIMOVELChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODCCUSTO", DbType="VarChar(25)")]
		public string CODCCUSTO
		{
			get
			{
				return this._CODCCUSTO;
			}
			set
			{
				if ((this._CODCCUSTO != value))
				{
					this.OnCODCCUSTOChanging(value);
					this.SendPropertyChanging();
					this._CODCCUSTO = value;
					this.SendPropertyChanged("CODCCUSTO");
					this.OnCODCCUSTOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODCOLCCUSTO", DbType="SmallInt")]
		public System.Nullable<short> CODCOLCCUSTO
		{
			get
			{
				return this._CODCOLCCUSTO;
			}
			set
			{
				if ((this._CODCOLCCUSTO != value))
				{
					this.OnCODCOLCCUSTOChanging(value);
					this.SendPropertyChanging();
					this._CODCOLCCUSTO = value;
					this.SendPropertyChanged("CODCOLCCUSTO");
					this.OnCODCOLCCUSTOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PERCENTPARTADM", DbType="Decimal(15,4)")]
		public System.Nullable<decimal> PERCENTPARTADM
		{
			get
			{
				return this._PERCENTPARTADM;
			}
			set
			{
				if ((this._PERCENTPARTADM != value))
				{
					this.OnPERCENTPARTADMChanging(value);
					this.SendPropertyChanging();
					this._PERCENTPARTADM = value;
					this.SendPropertyChanged("PERCENTPARTADM");
					this.OnPERCENTPARTADMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CONTROLADOM2", DbType="SmallInt")]
		public System.Nullable<short> CONTROLADOM2
		{
			get
			{
				return this._CONTROLADOM2;
			}
			set
			{
				if ((this._CONTROLADOM2 != value))
				{
					this.OnCONTROLADOM2Changing(value);
					this.SendPropertyChanging();
					this._CONTROLADOM2 = value;
					this.SendPropertyChanged("CONTROLADOM2");
					this.OnCONTROLADOM2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIPOLOCACAOAREA", DbType="Int")]
		public System.Nullable<int> TIPOLOCACAOAREA
		{
			get
			{
				return this._TIPOLOCACAOAREA;
			}
			set
			{
				if ((this._TIPOLOCACAOAREA != value))
				{
					this.OnTIPOLOCACAOAREAChanging(value);
					this.SendPropertyChanging();
					this._TIPOLOCACAOAREA = value;
					this.SendPropertyChanged("TIPOLOCACAOAREA");
					this.OnTIPOLOCACAOAREAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_METROQUADRADOLOCADO", DbType="Decimal(15,4)")]
		public System.Nullable<decimal> METROQUADRADOLOCADO
		{
			get
			{
				return this._METROQUADRADOLOCADO;
			}
			set
			{
				if ((this._METROQUADRADOLOCADO != value))
				{
					this.OnMETROQUADRADOLOCADOChanging(value);
					this.SendPropertyChanging();
					this._METROQUADRADOLOCADO = value;
					this.SendPropertyChanged("METROQUADRADOLOCADO");
					this.OnMETROQUADRADOLOCADOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_METROQUADRADODISPONIVEL", DbType="Decimal(15,4)")]
		public System.Nullable<decimal> METROQUADRADODISPONIVEL
		{
			get
			{
				return this._METROQUADRADODISPONIVEL;
			}
			set
			{
				if ((this._METROQUADRADODISPONIVEL != value))
				{
					this.OnMETROQUADRADODISPONIVELChanging(value);
					this.SendPropertyChanging();
					this._METROQUADRADODISPONIVEL = value;
					this.SendPropertyChanged("METROQUADRADODISPONIVEL");
					this.OnMETROQUADRADODISPONIVELChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_METROQUADRADOLOCAVEL", DbType="Decimal(15,4)")]
		public System.Nullable<decimal> METROQUADRADOLOCAVEL
		{
			get
			{
				return this._METROQUADRADOLOCAVEL;
			}
			set
			{
				if ((this._METROQUADRADOLOCAVEL != value))
				{
					this.OnMETROQUADRADOLOCAVELChanging(value);
					this.SendPropertyChanging();
					this._METROQUADRADOLOCAVEL = value;
					this.SendPropertyChanged("METROQUADRADOLOCAVEL");
					this.OnMETROQUADRADOLOCAVELChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_METROQUADRADORESERVADO", DbType="Decimal(15,4)")]
		public System.Nullable<decimal> METROQUADRADORESERVADO
		{
			get
			{
				return this._METROQUADRADORESERVADO;
			}
			set
			{
				if ((this._METROQUADRADORESERVADO != value))
				{
					this.OnMETROQUADRADORESERVADOChanging(value);
					this.SendPropertyChanging();
					this._METROQUADRADORESERVADO = value;
					this.SendPropertyChanged("METROQUADRADORESERVADO");
					this.OnMETROQUADRADORESERVADOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODCARTORIO", DbType="Int")]
		public System.Nullable<int> CODCARTORIO
		{
			get
			{
				return this._CODCARTORIO;
			}
			set
			{
				if ((this._CODCARTORIO != value))
				{
					this.OnCODCARTORIOChanging(value);
					this.SendPropertyChanging();
					this._CODCARTORIO = value;
					this.SendPropertyChanged("CODCARTORIO");
					this.OnCODCARTORIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODCOLPREFEITURA", DbType="SmallInt")]
		public System.Nullable<short> CODCOLPREFEITURA
		{
			get
			{
				return this._CODCOLPREFEITURA;
			}
			set
			{
				if ((this._CODCOLPREFEITURA != value))
				{
					this.OnCODCOLPREFEITURAChanging(value);
					this.SendPropertyChanging();
					this._CODCOLPREFEITURA = value;
					this.SendPropertyChanged("CODCOLPREFEITURA");
					this.OnCODCOLPREFEITURAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODPREFEITURA", DbType="VarChar(25)")]
		public string CODPREFEITURA
		{
			get
			{
				return this._CODPREFEITURA;
			}
			set
			{
				if ((this._CODPREFEITURA != value))
				{
					this.OnCODPREFEITURAChanging(value);
					this.SendPropertyChanging();
					this._CODPREFEITURA = value;
					this.SendPropertyChanged("CODPREFEITURA");
					this.OnCODPREFEITURAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODREGIAO", DbType="Int")]
		public System.Nullable<int> CODREGIAO
		{
			get
			{
				return this._CODREGIAO;
			}
			set
			{
				if ((this._CODREGIAO != value))
				{
					this.OnCODREGIAOChanging(value);
					this.SendPropertyChanging();
					this._CODREGIAO = value;
					this.SendPropertyChanged("CODREGIAO");
					this.OnCODREGIAOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODTIPOIMOVEL", DbType="Int")]
		public System.Nullable<int> CODTIPOIMOVEL
		{
			get
			{
				return this._CODTIPOIMOVEL;
			}
			set
			{
				if ((this._CODTIPOIMOVEL != value))
				{
					this.OnCODTIPOIMOVELChanging(value);
					this.SendPropertyChanging();
					this._CODTIPOIMOVEL = value;
					this.SendPropertyChanged("CODTIPOIMOVEL");
					this.OnCODTIPOIMOVELChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOCALIZACAO", DbType="VarChar(MAX)")]
		public string LOCALIZACAO
		{
			get
			{
				return this._LOCALIZACAO;
			}
			set
			{
				if ((this._LOCALIZACAO != value))
				{
					this.OnLOCALIZACAOChanging(value);
					this.SendPropertyChanging();
					this._LOCALIZACAO = value;
					this.SendPropertyChanged("LOCALIZACAO");
					this.OnLOCALIZACAOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_REGULARIZADO", DbType="SmallInt")]
		public System.Nullable<short> REGULARIZADO
		{
			get
			{
				return this._REGULARIZADO;
			}
			set
			{
				if ((this._REGULARIZADO != value))
				{
					this.OnREGULARIZADOChanging(value);
					this.SendPropertyChanging();
					this._REGULARIZADO = value;
					this.SendPropertyChanged("REGULARIZADO");
					this.OnREGULARIZADOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATAAQUISICAO", DbType="DateTime2")]
		public System.Nullable<System.DateTime> DATAAQUISICAO
		{
			get
			{
				return this._DATAAQUISICAO;
			}
			set
			{
				if ((this._DATAAQUISICAO != value))
				{
					this.OnDATAAQUISICAOChanging(value);
					this.SendPropertyChanging();
					this._DATAAQUISICAO = value;
					this.SendPropertyChanged("DATAAQUISICAO");
					this.OnDATAAQUISICAOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODCOLITEMCONTABIL", DbType="SmallInt")]
		public System.Nullable<short> CODCOLITEMCONTABIL
		{
			get
			{
				return this._CODCOLITEMCONTABIL;
			}
			set
			{
				if ((this._CODCOLITEMCONTABIL != value))
				{
					this.OnCODCOLITEMCONTABILChanging(value);
					this.SendPropertyChanging();
					this._CODCOLITEMCONTABIL = value;
					this.SendPropertyChanged("CODCOLITEMCONTABIL");
					this.OnCODCOLITEMCONTABILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDITEMCONTABIL", DbType="Int")]
		public System.Nullable<int> IDITEMCONTABIL
		{
			get
			{
				return this._IDITEMCONTABIL;
			}
			set
			{
				if ((this._IDITEMCONTABIL != value))
				{
					this.OnIDITEMCONTABILChanging(value);
					this.SendPropertyChanging();
					this._IDITEMCONTABIL = value;
					this.SendPropertyChanged("IDITEMCONTABIL");
					this.OnIDITEMCONTABILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODCOLCLASSEVALOR", DbType="SmallInt")]
		public System.Nullable<short> CODCOLCLASSEVALOR
		{
			get
			{
				return this._CODCOLCLASSEVALOR;
			}
			set
			{
				if ((this._CODCOLCLASSEVALOR != value))
				{
					this.OnCODCOLCLASSEVALORChanging(value);
					this.SendPropertyChanging();
					this._CODCOLCLASSEVALOR = value;
					this.SendPropertyChanged("CODCOLCLASSEVALOR");
					this.OnCODCOLCLASSEVALORChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCLASSEVALOR", DbType="Int")]
		public System.Nullable<int> IDCLASSEVALOR
		{
			get
			{
				return this._IDCLASSEVALOR;
			}
			set
			{
				if ((this._IDCLASSEVALOR != value))
				{
					this.OnIDCLASSEVALORChanging(value);
					this.SendPropertyChanging();
					this._IDCLASSEVALOR = value;
					this.SendPropertyChanged("IDCLASSEVALOR");
					this.OnIDCLASSEVALORChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_INTEGRACAOPORTAIS", DbType="SmallInt NOT NULL")]
		public short INTEGRACAOPORTAIS
		{
			get
			{
				return this._INTEGRACAOPORTAIS;
			}
			set
			{
				if ((this._INTEGRACAOPORTAIS != value))
				{
					this.OnINTEGRACAOPORTAISChanging(value);
					this.SendPropertyChanging();
					this._INTEGRACAOPORTAIS = value;
					this.SendPropertyChanged("INTEGRACAOPORTAIS");
					this.OnINTEGRACAOPORTAISChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OBSERVACAO", DbType="VarChar(MAX)")]
		public string OBSERVACAO
		{
			get
			{
				return this._OBSERVACAO;
			}
			set
			{
				if ((this._OBSERVACAO != value))
				{
					this.OnOBSERVACAOChanging(value);
					this.SendPropertyChanging();
					this._OBSERVACAO = value;
					this.SendPropertyChanged("OBSERVACAO");
					this.OnOBSERVACAOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COD_TIPO_IMOVEL", DbType="Int")]
		public System.Nullable<int> COD_TIPO_IMOVEL
		{
			get
			{
				return this._COD_TIPO_IMOVEL;
			}
			set
			{
				if ((this._COD_TIPO_IMOVEL != value))
				{
					this.OnCOD_TIPO_IMOVELChanging(value);
					this.SendPropertyChanging();
					this._COD_TIPO_IMOVEL = value;
					this.SendPropertyChanged("COD_TIPO_IMOVEL");
					this.OnCOD_TIPO_IMOVELChanged();
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