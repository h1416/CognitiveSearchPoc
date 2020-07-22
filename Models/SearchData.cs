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

        // Used when page numbers, or next or prev buttons, have been selected.
        public string paging { get; set; }

        //filter strings to the SearchData model
        public string categoryFilter { get; set; }
        //filter strings to the SearchData model
        public string amenityFilter { get; set; }

        // The list of results.
        public DocumentSearchResult<Hotel> resultList;
    }

}
