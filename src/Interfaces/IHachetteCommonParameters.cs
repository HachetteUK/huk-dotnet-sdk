using System;
using System.Collections.ObjectModel;
using Hachette.API.SDK.Common;

namespace Hachette.API.SDK.Interfaces
{
    /// <summary>
    /// Interface describing common querystring parameters for
    /// Hachette UK API.
    /// </summary>
    public interface IHachetteCommonParameters
    {
        /// <summary>
        /// Retrieve ID field.
        /// </summary>
        /// <value></value>
        string Id {get;set;}
        /// <summary>
        /// Retrieve API Imprint names you want the Hachette API to filter on.
        /// </summary>
         ReadOnlyCollection<string> FilterByImprints {get;}
        /// <summary>
        /// Retrieve API Divisions names you want the Hachette API to filter on.
        /// </summary>
        ReadOnlyCollection<string> FilterByDivisions {get;}
        /// <summary>
        /// Filter by Date since the resource was last updated.
        /// </summary>
        DateTimeOffset? FilterByTimestamp {get;set;}
        /// <summary>
        /// Filter on if a resource is active or not.
        /// </summary>
        /// <value></value>
        bool? FilterByIsActive {get;set;}
        /// <summary>
        /// Set a limit of how many records are returned.
        /// </summary>
        /// <value></value>
        int? Limit {get;set;}
        /// <summary>
        /// If Paging a large record set, pass in the Page number on where for the Hachette API
        /// to continue from (or start if the beginning of the query).
        /// </summary>
        /// <value></value>
        int? Page {get;set;}

        /// <summary>
        /// Add a division to filterByDivision parameter.
        /// </summary>
        /// <param name="division"></param>
        (bool,ValidationAddStatus) AddDivision(string division);
        /// <summary>
        /// Add a imprint to filterByImprint parameter.
        /// </summary>
        /// <param name="imprint"></param>
        (bool,ValidationAddStatus)  AddImprint(string imprint);
        /// <summary>
        /// Remove a division to filterByDivision parameter.
        /// </summary>
        /// <param name="division"></param>
        void RemoveDivision(string division);
        /// <summary>
        /// Remove a imprint to filterByImprint parameter.
        /// </summary>
        /// <param name="imprint"></param>
        void RemoveImprint(string imprint);

    }
}