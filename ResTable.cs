using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;

namespace MacOSApp_Game_2
{
    public class ResTable
    {
        public string Title { get; set;} = "";
        public string Description { get; set;} = "";
        public ResTable ()
        {
        }

        public ResTable (string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }
    }
    
     public class ResTableDataSource : NSTableViewDataSource
    {
        public List<ResTable> Results = new List<ResTable>();

        public ResTableDataSource ()
        {
        }

        public override nint GetRowCount (NSTableView tableView)
        {
            return Results.Count;
        }
    }
    
    public class ResTableDelegate: NSTableViewDelegate
    {
        private const string CellIdentifier = "ProdCell";

        private ResTableDataSource DataSource;

        public ResTableDelegate (ResTableDataSource datasource)
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
                case "Назва спеціальності":
                    view.StringValue = DataSource.Results [(int)row].Title;
                    break;
                case "Результат (%)":
                    view.StringValue = DataSource.Results [(int)row].Description;
                    break;
            }
            // Set line break mode to word wrap
            view.LineBreakMode = NSLineBreakMode.TruncatingTail;

            return view;
        }
    }
}