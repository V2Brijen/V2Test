﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace SingletonMVC.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class masterEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new masterEntities object using the connection string found in the 'masterEntities' section of the application configuration file.
        /// </summary>
        public masterEntities() : base("name=masterEntities", "masterEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new masterEntities object.
        /// </summary>
        public masterEntities(string connectionString) : base(connectionString, "masterEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new masterEntities object.
        /// </summary>
        public masterEntities(EntityConnection connection) : base(connection, "masterEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Sample> Samples
        {
            get
            {
                if ((_Samples == null))
                {
                    _Samples = base.CreateObjectSet<Sample>("Samples");
                }
                return _Samples;
            }
        }
        private ObjectSet<Sample> _Samples;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Samples EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSamples(Sample sample)
        {
            base.AddObject("Samples", sample);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="masterModel", Name="Sample")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Sample : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Sample object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Sample CreateSample(global::System.Int32 id, global::System.String name)
        {
            Sample sample = new Sample();
            sample.ID = id;
            sample.Name = name;
            return sample;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SomeText
        {
            get
            {
                return _SomeText;
            }
            set
            {
                OnSomeTextChanging(value);
                ReportPropertyChanging("SomeText");
                _SomeText = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SomeText");
                OnSomeTextChanged();
            }
        }
        private global::System.String _SomeText;
        partial void OnSomeTextChanging(global::System.String value);
        partial void OnSomeTextChanged();

        #endregion
    
    }

    #endregion
    
}
