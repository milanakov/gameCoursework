using System;
using AppKit;

namespace MacOSApp_Game_2
{
    public partial class ResultsAndUni : NSViewController
    {
        public ResultsAndUni(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			
            NSColor backgroundColor = NSColor.FromRgb(
                (nfloat)(0xDF / 255.0),
                (nfloat)(0xE4 / 255.0),
                (nfloat)(0xEA / 255.0)
            ); //DFE4EA
            // Set the background color of the view
            View.WantsLayer = true;
            if (View.Layer != null) View.Layer.BackgroundColor = backgroundColor.CGColor;
            
            textFieldResult.WantsLayer = true;
            if (textFieldResult.Layer != null)
            {
                textFieldResult.Layer.CornerRadius = 10f;

                var textColor = NSColor.White;
                textFieldResult.TextColor = textColor;

                // Change the text field color
                var textFieldColor =
                    NSColor.FromRgba(0x55 / 255f, 0xB0 / 255f, 0xFF / 255f, 1f); // Set the desired color
                textFieldResult.BackgroundColor = textFieldColor;
                //55b0ff

                // Update the text field appearance
                textFieldResult.Layer.BackgroundColor = textFieldColor.CGColor;
                textFieldResult.Layer.BorderColor = textFieldColor.CGColor;
                textFieldResult.Layer.BorderWidth = 1f;
            }
            // Set the font size to 14sp
            var fontSize = 14f;
            var font = NSFont.SystemFontOfSize(fontSize, NSFontWeight.Regular);
            textFieldResult.Font = font;
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib ();

            // Create the Product Table Data Source and populate it
            var resDataSource = new ResTableDataSource ();
            resDataSource.Results.Add (new ResTable ("Кімната 121 (Інженерія програмного забезпечення)", 
                Result121.ResultPercent));
            resDataSource.Results.Add (new ResTable ("Кімната 122 (Комп'ютерні науки)", 
                Result122.ResultPercent));
            resDataSource.Results.Add (new ResTable ("Кімната 123 (Комп'ютерна інженерія)", 
                "-"));
            resDataSource.Results.Add (new ResTable ("Кімната 124 (Системний аналіз)", 
                "-"));
            resDataSource.Results.Add (new ResTable ("Кімната 125 (Кібербезпека)", 
                "-"));
            resDataSource.Results.Add (new ResTable ("Кімната 126 (Інформаційні системи та технології)", 
                "-"));
            
            // Set the frame size of the table view
            /*var tableFrame = resTableView.Frame;
            tableFrame.Size = new CoreGraphics.CGSize(100, 100);
            resTableView.Frame = tableFrame;*/
            
            var scrollViewFrame = resultsScrollView.Frame;
            //scrollViewFrame.Size = new CoreGraphics.CGSize(575, 175);
            //resultsScrollView.Frame = scrollViewFrame;
            
            // Set the frame origin of the scroll view
            scrollViewFrame.Location = new CoreGraphics.CGPoint(197, 290);
            resultsScrollView.Frame = scrollViewFrame;
            
            // Populate the Product Table
            resTableView.DataSource = resDataSource;
            resTableView.Delegate = new ResTableDelegate (resDataSource);
            
            
            var uni121DataSource = new Table121DataSource ();
            uni121DataSource.Uni121.Add (new Table121 ("1",
                "Київський національний університет імені Тараса Шевченка", 
                "Факультет інформаційних технологій", "140", "52", "191.03", 
                "173.05", "38000 грн", "Київ"));
            uni121DataSource.Uni121.Add (new Table121 ("2",
                "Київський національний університет імені Тараса Шевченка", 
                "Факультет комп'ютерних наук та кібернетики","100", "36", "195.70", 
                "172.14", "38000 грн", "Київ"));
            uni121DataSource.Uni121.Add (new Table121 ("3",
                "Київський національний університет імені Тараса Шевченка", 
                "Факультет комп'ютерних наук та кібернетики","35", "-", "-", 
                "134.7", "38000 грн", "Київ"));
            uni121DataSource.Uni121.Add (new Table121 ("4",
                "Національний технічний університет України 'Київський політехнічний інститут імені Ігоря Сікорського'", 
                "Навчально-науковий інститут атомної та теплової енергетики","90", "75", 
                "188.48", "160.87", "45000 грн", "Київ"));
            uni121DataSource.Uni121.Add (new Table121 ("5",
                "Національний технічний університет України 'Київський політехнічний інститут імені Ігоря Сікорського'", 
                "Факультет інформатики та обчислювальної техніки","270", "165", "193.19", 
                "181.60", "45000 грн", "Київ"));
            uni121DataSource.Uni121.Add (new Table121 ("6",
                "Національний технічний університет України 'Київський політехнічний інститут імені Ігоря Сікорського'", 
                "Факультет прикладної математики","85", "62", "189.99", 
                "175.08", "45000 грн", "Київ"));
            uni121DataSource.Uni121.Add (new Table121 ("7",
                "Національний університет 'Києво-Могилянська академія'", 
                "Факультет інформатики","66", "61", "194.28", 
                "184.52", "55000 грн", "Київ"));
            uni121DataSource.Uni121.Add (new Table121 ("8", "Державний університет телекомунікацій", 
                "Навчально-науковий інститут Інформаційних технологій","120", "7", 
                "179.96", "152.83", "31450 грн", "Київ"));
            uni121DataSource.Uni121.Add (new Table121 ("9", "Національний авіаційний університет", 
                "Факультет кібербезпеки, комп`ютерної та програмної інженерії","100", "88", 
                "185.00", "158.46", "29000 грн", "Київ"));
            uni121DataSource.Uni121.Add (new Table121 ("10", "Європейський університет", 
                "Факультет Інформаційних систем та технологій","250", "-", "-", 
                "144.44", "20000 грн", "Київ"));
            uni121DataSource.Uni121.Add (new Table121 ("11", "Національний університет 'Львівська політехніка'", 
                "Інститут комп'ютерних наук та інформаційних технологій","220", "202", 
                "191.31", "179.72", "45000 грн", "Львів"));
            uni121DataSource.Uni121.Add (new Table121 ("12", "Рівненський державний гуманітарний університет", 
                "Факультет математики та інформатики","93", "7", 
                "166.44", "135.63", "24700 грн", "Рівне"));
            uni121DataSource.Uni121.Add (new Table121 ("13", 
                "Національний технічний університет 'Харківський політехнічний інститут'", 
                "Навчально-науковий інститут комп'ютерних наук та інформаційних технологій","200", 
                "130", "185.29", "155.36", "30470 грн", "Харків"));
            uni121DataSource.Uni121.Add (new Table121 ("14", "Національний університет 'Запорізька політехніка'", 
                "Факультет комп'ютерних наук і технологій","150", "35", "178.41", 
                "148.54", "19100 грн", "Запоріжжя"));
            uni121DataSource.Uni121.Add (new Table121 ("15", "Хмельницький національний університет", 
                "Факультет інформаційних технологій","30", 
                "23", "176.47", "155.21", "36500 грн", "Хмельницький"));
            uni121DataSource.Uni121.Add (new Table121 ("16", "Національний університет 'Чернігівська політехніка'", 
                "Навчально-науковий інститут Електронних та інформаційних технологій",
                "100", "30", "183.80", "152.01", "29216 грн", "Чернігів"));
            
            uni121TableView.DataSource = uni121DataSource;
            uni121TableView.Delegate = new Table121Delegate (uni121DataSource);
        }
        
        // Connect the button to the method
        partial void updateResTable(NSButton sender)
        {
            // Reload the table data
            AwakeFromNib();
            var scrollViewFrame = resultsScrollView.Frame;

            // Set the frame origin of the scroll view
            scrollViewFrame.Location = new CoreGraphics.CGPoint(197, 262);
            resultsScrollView.Frame = scrollViewFrame;
        }


        /*
        public class CSVLoader
        {
            public static List<Table121> LoadDataFromCSV(string csvFilePath)
            {
                var data = new List<Table121>();

                using (var reader = new StreamReader(csvFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values.Length == 7)
                        {
                            string roomName = values[0].Trim();
                            string roomInfo = values[1].Trim();
                            string smth = values[2].Trim();
                            string smth1 = values[3].Trim();
                            string smth2 = values[4].Trim();
                            string smth3 = values[5].Trim();
                            string smth4 = values[6].Trim();
                            data.Add(new Table121(roomName, roomInfo, smth,
                                smth1, smth2, smth3, smth4));
                        }
                    }
                }

                return data;
            }
        }*/


        partial void menuSegmentedControl(NSSegmentedControl sender)
        {
            if (sender.SelectedSegment == 0)
            {
                resultsScrollView.Hidden = false;
                updateResTableButton.Hidden = false;
                uni121ScrollView.Hidden = true;
                cButton.Hidden = true;
                copyrightText.Hidden = true;
                // Display the Specialty Table
                //resTableView.Hidden = false;
            }
            else if (sender.SelectedSegment == 1)
            {
                //resultsTable.Hidden = false;
                resultsScrollView.Hidden = true;
                updateResTableButton.Hidden = true;
                uni121ScrollView.Hidden = false;
                cButton.Hidden = false;
                copyrightText.Hidden = false;
            }
            else if (sender.SelectedSegment == 2)
            {
                // Hide the Specialty Table
                resultsScrollView.Hidden = true;
                updateResTableButton.Hidden = true;
                uni121ScrollView.Hidden = true;
                cButton.Hidden = false;
                copyrightText.Hidden = false;

            }
            else if (sender.SelectedSegment == 3)
            {
                // Hide the Specialty Table
                resultsScrollView.Hidden = true;
                updateResTableButton.Hidden = true;
                uni121ScrollView.Hidden = true;
                cButton.Hidden = false;
                copyrightText.Hidden = false;

            }
            else if (sender.SelectedSegment == 4)
            {
                // Hide the Specialty Table
                resultsScrollView.Hidden = true;
                updateResTableButton.Hidden = true;
                uni121ScrollView.Hidden = true;
                cButton.Hidden = false;
                copyrightText.Hidden = false;

            }
            else if (sender.SelectedSegment == 5)
            {
                // Hide the Specialty Table
                resultsScrollView.Hidden = true;
                updateResTableButton.Hidden = true;
                uni121ScrollView.Hidden = true;
                cButton.Hidden = false;
                copyrightText.Hidden = false;

            }
            else if (sender.SelectedSegment == 6)
            {
                // Hide the Specialty Table
                resultsScrollView.Hidden = true;
                updateResTableButton.Hidden = true;
                uni121ScrollView.Hidden = true;
                cButton.Hidden = false;
                copyrightText.Hidden = false;

            }
        }
    }
}