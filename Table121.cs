using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;

namespace MacOSApp_Game_2
{
    public class Table121
    {
        public string Number { get; set;} = "";
        public string Title { get; set;} = "";
        public string Description { get; set;} = "";
        public string NumAll { get; set;} = "";
        public string NumBudg { get; set;} = "";
        public string ScoreBudg { get; set;} = "";
        public string ScoreContr { get; set;} = "";
        public string PriceYear { get; set;} = "";
        public string City { get; set;} = "";
        public Table121 ()
        {
        }

        public Table121 (string number, string title, string description, string numAll, string numBudg, string scoreBudg,
            string scoreContr, string priceYear, string city)
        {
            this.Number = number;
            this.Title = title;
            this.Description = description;
            this.NumAll = numAll;
            this.NumBudg = numBudg;
            this.ScoreBudg = scoreBudg;
            this.ScoreContr = scoreContr;
            this.PriceYear = priceYear;
            this.City = city;
        }
    }
    
    public class Table121DataSource : NSTableViewDataSource
    {
        public List<Table121> Uni121 = new List<Table121>();

        public Table121DataSource ()
        {
        }

        public override nint GetRowCount (NSTableView tableView)
        {
            return Uni121.Count;
        }
    }
    
    public class Table121Delegate: NSTableViewDelegate
    {
        private const string CellIdentifier = "ProdCell";

        private Table121DataSource DataSource;

        public Table121Delegate (Table121DataSource datasource)
        {
            this.DataSource = datasource;
        }

        public override NSView GetViewForItem (NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            // This pattern allows you reuse existing views when they are no-longer in use.
            // If the returned view is null, you instance up a new view
            // If a non-null view is returned, you modify it enough to reflect the new data
            NSTextField view = (NSTextField)tableView.MakeView (CellIdentifier, this);
            if (view == null) {
                view = new NSTextField ();
                view.Identifier = CellIdentifier;
                view.BackgroundColor = NSColor.Clear;
                view.Bordered = false;
                view.Selectable = false;
                view.Editable = false;
            }
            // Setup view based on the column selected
            switch (tableColumn.Title) {
                case "№":
                    view.StringValue = DataSource.Uni121 [(int)row].Number;
                    break;
                case "Університет":
                    view.StringValue = DataSource.Uni121 [(int)row].Title;
                    break;
                case "Факультет":
                    view.StringValue = DataSource.Uni121 [(int)row].Description;
                    break;
                case "К-сть місць":
                    view.StringValue = DataSource.Uni121 [(int)row].NumAll;
                    break;
                case "К-сть бюджетних місць":
                    view.StringValue = DataSource.Uni121 [(int)row].NumBudg;
                    break;
                case "Середній бал на бюджет":
                    view.StringValue = DataSource.Uni121 [(int)row].ScoreBudg;
                    break;
                case "Середній бал на контракт":
                    view.StringValue = DataSource.Uni121 [(int)row].ScoreContr;
                    break;
                case "Ціна за рік":
                    view.StringValue = DataSource.Uni121 [(int)row].PriceYear;
                    break;
                case "Місто":
                    view.StringValue = DataSource.Uni121 [(int)row].City;
                    break;
            }
            // Set line break mode to word wrap
            view.LineBreakMode = NSLineBreakMode.TruncatingTail;

            return view;
        }
        public override nfloat GetRowHeight(NSTableView tableView, nint row)
        {
            // Specify the desired row height here
            return 25f; // Change this value to your desired height
        }
    }
}