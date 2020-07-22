using Microsoft.Azure.Search.Models;

namespace AzureSearchPoc.Models
{
    public class SearchData
    {
        // The text to search for.
        public string searchText { get; set; }

        // The current page being displayed.
        public int currentPage { get; set; }

        // The total number of pages of results.
        public int pageCount { get; set; }

        // The left-most page number to display.
        public int leftMostPage { get; set; }

        // The number of page numbers to display - which can be less than MaxPageRange towards the end of the results.
        public int pageRange { get; set; }

        /// <summary>
        /// This is for paging option
        /// </summary>
        //// Used when page numbers, or next or prev buttons, have been selected.
        //public string paging { get; set; }

        //This is for infinite scrolling option
        // Record if the next page is requested.
        public string paging { get; set; }

        // The list of results.
        public DocumentSearchResult<Hotel> resultList;
    }

}
