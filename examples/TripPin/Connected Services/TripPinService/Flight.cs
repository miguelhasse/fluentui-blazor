﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/13/2024 12:10:48
namespace FluentUI.TripPin.Model
{
    /// <summary>
    /// There are no comments for FlightSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FlightSingle")]
    public partial class FlightSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Flight>
    {
        /// <summary>
        /// Initialize a new FlightSingle object.
        /// </summary>
        public FlightSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FlightSingle object.
        /// </summary>
        public FlightSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FlightSingle object.
        /// </summary>
        public FlightSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Flight> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for From in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("From")]
        public virtual global::FluentUI.TripPin.Model.AirportSingle From
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._From == null))
                {
                    this._From = new global::FluentUI.TripPin.Model.AirportSingle(this.Context, GetPath("From"));
                }
                return this._From;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::FluentUI.TripPin.Model.AirportSingle _From;
        /// <summary>
        /// There are no comments for To in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("To")]
        public virtual global::FluentUI.TripPin.Model.AirportSingle To
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._To == null))
                {
                    this._To = new global::FluentUI.TripPin.Model.AirportSingle(this.Context, GetPath("To"));
                }
                return this._To;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::FluentUI.TripPin.Model.AirportSingle _To;
        /// <summary>
        /// There are no comments for Airline in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Airline")]
        public virtual global::FluentUI.TripPin.Model.AirlineSingle Airline
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Airline == null))
                {
                    this._Airline = new global::FluentUI.TripPin.Model.AirlineSingle(this.Context, GetPath("Airline"));
                }
                return this._Airline;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::FluentUI.TripPin.Model.AirlineSingle _Airline;
    }
    /// <summary>
    /// There are no comments for Flight in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PlanItemId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PlanItemId")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Flight")]
    public partial class Flight : PublicTransportation
    {
        /// <summary>
        /// Create a new Flight object.
        /// </summary>
        /// <param name="planItemId">Initial value of PlanItemId.</param>
        /// <param name="flightNumber">Initial value of FlightNumber.</param>
        /// <param name="from">Initial value of From.</param>
        /// <param name="to">Initial value of To.</param>
        /// <param name="airline">Initial value of Airline.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Flight CreateFlight(int planItemId, string flightNumber, global::FluentUI.TripPin.Model.Airport from, global::FluentUI.TripPin.Model.Airport to, global::FluentUI.TripPin.Model.Airline airline)
        {
            Flight flight = new Flight();
            flight.PlanItemId = planItemId;
            flight.FlightNumber = flightNumber;
            if ((from == null))
            {
                throw new global::System.ArgumentNullException("from");
            }
            flight.From = from;
            if ((to == null))
            {
                throw new global::System.ArgumentNullException("to");
            }
            flight.To = to;
            if ((airline == null))
            {
                throw new global::System.ArgumentNullException("airline");
            }
            flight.Airline = airline;
            return flight;
        }
        /// <summary>
        /// There are no comments for Property FlightNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FlightNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FlightNumber is required.")]
        public virtual string FlightNumber
        {
            get
            {
                return this._FlightNumber;
            }
            set
            {
                this.OnFlightNumberChanging(value);
                this._FlightNumber = value;
                this.OnFlightNumberChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FlightNumber;
        partial void OnFlightNumberChanging(string value);
        partial void OnFlightNumberChanged();
        /// <summary>
        /// There are no comments for Property From in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("From")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "From is required.")]
        public virtual global::FluentUI.TripPin.Model.Airport From
        {
            get
            {
                return this._From;
            }
            set
            {
                this.OnFromChanging(value);
                this._From = value;
                this.OnFromChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::FluentUI.TripPin.Model.Airport _From;
        partial void OnFromChanging(global::FluentUI.TripPin.Model.Airport value);
        partial void OnFromChanged();
        /// <summary>
        /// There are no comments for Property To in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("To")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "To is required.")]
        public virtual global::FluentUI.TripPin.Model.Airport To
        {
            get
            {
                return this._To;
            }
            set
            {
                this.OnToChanging(value);
                this._To = value;
                this.OnToChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::FluentUI.TripPin.Model.Airport _To;
        partial void OnToChanging(global::FluentUI.TripPin.Model.Airport value);
        partial void OnToChanged();
        /// <summary>
        /// There are no comments for Property Airline in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Airline")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Airline is required.")]
        public virtual global::FluentUI.TripPin.Model.Airline Airline
        {
            get
            {
                return this._Airline;
            }
            set
            {
                this.OnAirlineChanging(value);
                this._Airline = value;
                this.OnAirlineChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::FluentUI.TripPin.Model.Airline _Airline;
        partial void OnAirlineChanging(global::FluentUI.TripPin.Model.Airline value);
        partial void OnAirlineChanged();
    }
}