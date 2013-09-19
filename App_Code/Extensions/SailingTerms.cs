namespace App_Code
{
    using System.Data;
    using BlogEngine.Core;
    using BlogEngine.Core.Web.Controls;
    using BlogEngine.Core.Web.Extensions;

    [Extension("Provides dictionary for Sailing Terms found in Posts", "1.0.0.0", "gerardo")]
    public class SailingTerms
    {
        static ExtensionSettings terms;
        public SailingTerms()
        {
            Post.Serving += PostServing;
        }

        private void PostServing(object sender, ServingEventArgs e)
        {
            var table = Terms.GetDataTable();
            const string s = "<a href=\"{0}\">{1}</a>";
            string originalWord;
            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    originalWord = row["Term"].ToString() + " ";
                    e.Body = e.Body.Replace(originalWord, string.Format(s, row["Url"], row["Term"]));
                    //originalWord = row["Term"].ToString() + ".";
                    //e.Body = e.Body.Replace(originalWord, string.Format(s, row["Url"], row["Term"].ToString() + "."));
                    originalWord = row["Term"].ToString() + ",";
                    e.Body = e.Body.Replace(originalWord, string.Format(s, row["Url"], row["Term"].ToString() + ","));
                    originalWord = row["Term"].ToString() + "!";
                    e.Body = e.Body.Replace(originalWord, string.Format(s, row["Url"], row["Term"].ToString() + "!"));
                    originalWord = " " + row["Term"].ToString().ToLower() + " ";
                    e.Body = e.Body.Replace(originalWord, string.Format(s, row["Url"], " " + row["Term"].ToString().ToLower() + " "));
                    //originalWord = " " + row["Term"].ToString().ToLower() + ".";
                    //e.Body = e.Body.Replace(originalWord, string.Format(s, row["Url"], " " + row["Term"].ToString().ToLower() + "."));
                    originalWord = " " + row["Term"].ToString().ToLower() + ",";
                    e.Body = e.Body.Replace(originalWord, string.Format(s, row["Url"], " " + row["Term"].ToString().ToLower() + ","));
                    originalWord = " " + row["Term"].ToString().ToLower() + "!";
                    e.Body = e.Body.Replace(originalWord, string.Format(s, row["Url"], " " + row["Term"].ToString().ToLower() + "!"));
                }
            }
        }

        public static ExtensionSettings Terms
        {
            get
            {
                if (terms == null)
                {
                    var extensionSettings = new ExtensionSettings();
                    extensionSettings.AddParameter("Term");
                    extensionSettings.AddParameter("Url");
                    //extensionSettings.AddValues(new[] { "tack", "http://www.sailingcanyonlake.com/Pictionary.aspx#T" });
                    extensionSettings.AddValues(new[] { "Abaft", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Abeam", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "About", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Adrift", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Aft", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Aloft", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Akas", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Ama", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Amidships", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Angle of attack", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Angle of Heel", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Apparent wind", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Aspect Ratio", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Astern", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Athwartships", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Avast", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Awash", "http://www.sailingcanyonlake.com/Pictionary.aspx#A" });
                    extensionSettings.AddValues(new[] { "Back stay", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bale", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Ballast", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Battens", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Batten Down", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Barque", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Barquentine", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Beachcomber", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Beam", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Beam Reach", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Beat", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Before the Wind", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Belay", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Belaying Pin", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Below", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bermuda Rig", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bight", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bilge", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bitter End", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Blanket", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Blanketed", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Blanketing", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Boat", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Boatswain", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bobstay", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bollard", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Boom", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Boomkin", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bosun's Chair", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bow", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bowline", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bowsprit", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Braces", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Breakers", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bridge", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Brig", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Brigands", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Brigantine", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Brightwork", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bring About", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Broach", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Broad Reach", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bucko", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bulkhead", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Bulwark", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Buoy", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "by the lee", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "by the wind", "http://www.sailingcanyonlake.com/Pictionary.aspx#B" });
                    extensionSettings.AddValues(new[] { "Camber", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Capsize", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Capstan", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Captain", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Cable", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Caravel", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Carrack", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Carrick Bend", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Catamaran", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Catboat", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Catspaw", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Caulking", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Celestial Navigation", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Centre board", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Centre of buoyancy", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Centre of effort", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Centre of lateral resistance", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Centre line", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Chief Mate", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Chine", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Chop", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Cleat", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Clew", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Coamings", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Come About", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Centre board", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Cuddy", "http://www.sailingcanyonlake.com/Pictionary.aspx#C" });
                    extensionSettings.AddValues(new[] { "Dagger board", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Day sailor", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Dead Ahead", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Dead Astern", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Deadhead", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Deadrise", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Deck", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Derelict", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Design Waterline (DWL)", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Dinghy", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Displacement", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Displacement Hull", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Distance Made Good", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Down haul", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Draft", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Drogue", "http://www.sailingcanyonlake.com/Pictionary.aspx#D" });
                    extensionSettings.AddValues(new[] { "Ebb tide", "http://www.sailingcanyonlake.com/Pictionary.aspx#E" });
                    extensionSettings.AddValues(new[] { "Ensign", "http://www.sailingcanyonlake.com/Pictionary.aspx#E" });
                    extensionSettings.AddValues(new[] { "Even keel", "http://www.sailingcanyonlake.com/Pictionary.aspx#E" });
                    extensionSettings.AddValues(new[] { "Eye splice", "http://www.sailingcanyonlake.com/Pictionary.aspx#E" });
                    extensionSettings.AddValues(new[] { "Eye of the wind", "http://www.sailingcanyonlake.com/Pictionary.aspx#E" });
                    extensionSettings.AddValues(new[] { "Fair", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Fair Wind", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Fairlead", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Fall Off", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Fathom", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Fetch", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Fid", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Figurehead", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Fin Keel", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Flare", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Flotsam", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Following Sea", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Fore", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Forefoot", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Fractional Rig", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Freeboard", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Full and By", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Fully battened", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Furl", "http://www.sailingcanyonlake.com/Pictionary.aspx#F" });
                    extensionSettings.AddValues(new[] { "Gaff", "http://www.sailingcanyonlake.com/Pictionary.aspx#G" });
                    extensionSettings.AddValues(new[] { "Gaff Topsail", "http://www.sailingcanyonlake.com/Pictionary.aspx#G" });
                    extensionSettings.AddValues(new[] { "Genoa", "http://www.sailingcanyonlake.com/Pictionary.aspx#G" });
                    extensionSettings.AddValues(new[] { "Give-Way", "http://www.sailingcanyonlake.com/Pictionary.aspx#G" });
                    extensionSettings.AddValues(new[] { "Global Positioning System", "http://www.sailingcanyonlake.com/Pictionary.aspx#G" });
                    extensionSettings.AddValues(new[] { "Gooseneck", "http://www.sailingcanyonlake.com/Pictionary.aspx#G" });
                    extensionSettings.AddValues(new[] { "Ground Swells", "http://www.sailingcanyonlake.com/Pictionary.aspx#G" });
                    extensionSettings.AddValues(new[] { "Gunkholing", "http://www.sailingcanyonlake.com/Pictionary.aspx#G" });
                    extensionSettings.AddValues(new[] { "Gunwale", "http://www.sailingcanyonlake.com/Pictionary.aspx#G" });
                    extensionSettings.AddValues(new[] { "Gybe", "http://www.sailingcanyonlake.com/Pictionary.aspx#G" });
                    extensionSettings.AddValues(new[] { "Halyard", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Hanks", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Hard Aground ", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Hard Chine", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Hawser", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Head Sea", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Head to Wind", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Head Up", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Headstay", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Heave To", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Heavy Seas", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Heel", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Helm", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Hike", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Hull", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "Hull Speed", "http://www.sailingcanyonlake.com/Pictionary.aspx#H" });
                    extensionSettings.AddValues(new[] { "In Irons", "http://www.sailingcanyonlake.com/Pictionary.aspx#I" });
                    extensionSettings.AddValues(new[] { "Jam Cleat", "http://www.sailingcanyonlake.com/Pictionary.aspx#J" });
                    extensionSettings.AddValues(new[] { "Jenny", "http://www.sailingcanyonlake.com/Pictionary.aspx#J" });
                    extensionSettings.AddValues(new[] { "Jetsam", "http://www.sailingcanyonlake.com/Pictionary.aspx#J" });
                    extensionSettings.AddValues(new[] { "Jib", "http://www.sailingcanyonlake.com/Pictionary.aspx#J" });
                    extensionSettings.AddValues(new[] { "Junk", "http://www.sailingcanyonlake.com/Pictionary.aspx#J" });
                    extensionSettings.AddValues(new[] { "Keel", "http://www.sailingcanyonlake.com/Pictionary.aspx#K" });
                    extensionSettings.AddValues(new[] { "Ketch", "http://www.sailingcanyonlake.com/Pictionary.aspx#K" });
                    extensionSettings.AddValues(new[] { "Knockabout", "http://www.sailingcanyonlake.com/Pictionary.aspx#K" });
                    extensionSettings.AddValues(new[] { "Knockdown", "http://www.sailingcanyonlake.com/Pictionary.aspx#K" });
                    extensionSettings.AddValues(new[] { "Knot", "http://www.sailingcanyonlake.com/Pictionary.aspx#K" });
                    extensionSettings.AddValues(new[] { "Lateen", "http://www.sailingcanyonlake.com/Pictionary.aspx#L" });
                    extensionSettings.AddValues(new[] { "Leach", "http://www.sailingcanyonlake.com/Pictionary.aspx#L" });
                    extensionSettings.AddValues(new[] { "Lee", "http://www.sailingcanyonlake.com/Pictionary.aspx#L" });
                    extensionSettings.AddValues(new[] { "Lee boards", "http://www.sailingcanyonlake.com/Pictionary.aspx#L" });
                    extensionSettings.AddValues(new[] { "Leeward", "http://www.sailingcanyonlake.com/Pictionary.aspx#L" });
                    extensionSettings.AddValues(new[] { "Leeway", "http://www.sailingcanyonlake.com/Pictionary.aspx#L" });
                    extensionSettings.AddValues(new[] { "Lift", "http://www.sailingcanyonlake.com/Pictionary.aspx#L" });
                    extensionSettings.AddValues(new[] { "Load Water Line", "http://www.sailingcanyonlake.com/Pictionary.aspx#L" });
                    extensionSettings.AddValues(new[] { "Loose-footed", "http://www.sailingcanyonlake.com/Pictionary.aspx#L" });
                    extensionSettings.AddValues(new[] { "Luff", "http://www.sailingcanyonlake.com/Pictionary.aspx#L" });
                    extensionSettings.AddValues(new[] { "Luffing", "http://www.sailingcanyonlake.com/Pictionary.aspx#L" });
                    extensionSettings.AddValues(new[] { "Lug or Lugsail", "http://www.sailingcanyonlake.com/Pictionary.aspx#L" });
                    extensionSettings.AddValues(new[] { "Main sail", "http://www.sailingcanyonlake.com/Pictionary.aspx#M" });
                    extensionSettings.AddValues(new[] { "Main sheet", "http://www.sailingcanyonlake.com/Pictionary.aspx#M" });
                    extensionSettings.AddValues(new[] { "Make Fast", "http://www.sailingcanyonlake.com/Pictionary.aspx#M" });
                    extensionSettings.AddValues(new[] { "Make Way", "http://www.sailingcanyonlake.com/Pictionary.aspx#M" });
                    extensionSettings.AddValues(new[] { "Marconi rig", "http://www.sailingcanyonlake.com/Pictionary.aspx#M" });
                    extensionSettings.AddValues(new[] { "Marlinspike", "http://www.sailingcanyonlake.com/Pictionary.aspx#M" });
                    extensionSettings.AddValues(new[] { "Mast", "http://www.sailingcanyonlake.com/Pictionary.aspx#M" });
                    extensionSettings.AddValues(new[] { "Mast Head ", "http://www.sailingcanyonlake.com/Pictionary.aspx#M" });
                    extensionSettings.AddValues(new[] { "Mast Step ", "http://www.sailingcanyonlake.com/Pictionary.aspx#M" });
                    extensionSettings.AddValues(new[] { "Mizzen", "http://www.sailingcanyonlake.com/Pictionary.aspx#M" });
                    extensionSettings.AddValues(new[] { "Multi-hull", "http://www.sailingcanyonlake.com/Pictionary.aspx#M" });
                    extensionSettings.AddValues(new[] { "Nautical", "http://www.sailingcanyonlake.com/Pictionary.aspx#N" });
                    extensionSettings.AddValues(new[] { "Neap-tide", "http://www.sailingcanyonlake.com/Pictionary.aspx#N" });
                    extensionSettings.AddValues(new[] { "Off the Wind", "http://www.sailingcanyonlake.com/Pictionary.aspx#O" });
                    extensionSettings.AddValues(new[] { "On the Wind", "http://www.sailingcanyonlake.com/Pictionary.aspx#O" });
                    extensionSettings.AddValues(new[] { "One-design", "http://www.sailingcanyonlake.com/Pictionary.aspx#O" });
                    extensionSettings.AddValues(new[] { "Out haul", "http://www.sailingcanyonlake.com/Pictionary.aspx#O" });
                    extensionSettings.AddValues(new[] { "Outrigger", "http://www.sailingcanyonlake.com/Pictionary.aspx#O" });
                    extensionSettings.AddValues(new[] { "Overhangs", "http://www.sailingcanyonlake.com/Pictionary.aspx#O" });
                    extensionSettings.AddValues(new[] { "Painter", "http://www.sailingcanyonlake.com/Pictionary.aspx#P" });
                    extensionSettings.AddValues(new[] { "Peak", "http://www.sailingcanyonlake.com/Pictionary.aspx#P" });
                    extensionSettings.AddValues(new[] { "Planning", "http://www.sailingcanyonlake.com/Pictionary.aspx#P" });
                    extensionSettings.AddValues(new[] { "Port", "http://www.sailingcanyonlake.com/Pictionary.aspx#P" });
                    extensionSettings.AddValues(new[] { "oint of sail", "http://www.sailingcanyonlake.com/Pictionary.aspx#o" });
                    extensionSettings.AddValues(new[] { "Proa", "http://www.sailingcanyonlake.com/Pictionary.aspx#P" });
                    extensionSettings.AddValues(new[] { "Reaching", "http://www.sailingcanyonlake.com/Pictionary.aspx#R" });
                    extensionSettings.AddValues(new[] { "Reefing", "http://www.sailingcanyonlake.com/Pictionary.aspx#R" });
                    extensionSettings.AddValues(new[] { "Rig", "http://www.sailingcanyonlake.com/Pictionary.aspx#R" });
                    extensionSettings.AddValues(new[] { "Rigging", "http://www.sailingcanyonlake.com/Pictionary.aspx#R" });
                    extensionSettings.AddValues(new[] { "Roach", "http://www.sailingcanyonlake.com/Pictionary.aspx#R" });
                    extensionSettings.AddValues(new[] { "Rudder", "http://www.sailingcanyonlake.com/Pictionary.aspx#R" });
                    extensionSettings.AddValues(new[] { "Run", "http://www.sailingcanyonlake.com/Pictionary.aspx#R" });
                    extensionSettings.AddValues(new[] { "Running", "http://www.sailingcanyonlake.com/Pictionary.aspx#R" });
                    extensionSettings.AddValues(new[] { "Schooner", "http://www.sailingcanyonlake.com/Pictionary.aspx#S" });
                    extensionSettings.AddValues(new[] { "Sheet", "http://www.sailingcanyonlake.com/Pictionary.aspx#S" });
                    extensionSettings.AddValues(new[] { "Ship", "http://www.sailingcanyonlake.com/Pictionary.aspx#S" });
                    extensionSettings.AddValues(new[] { "Shoal", "http://www.sailingcanyonlake.com/Pictionary.aspx#S" });
                    extensionSettings.AddValues(new[] { "Spar", "http://www.sailingcanyonlake.com/Pictionary.aspx#S" });
                    extensionSettings.AddValues(new[] { "Spring tide", "http://www.sailingcanyonlake.com/Pictionary.aspx#S" });
                    extensionSettings.AddValues(new[] { "Sprit", "http://www.sailingcanyonlake.com/Pictionary.aspx#S" });
                    extensionSettings.AddValues(new[] { "Spreaders", "http://www.sailingcanyonlake.com/Pictionary.aspx#S" });
                    extensionSettings.AddValues(new[] { "Stand-On", "http://www.sailingcanyonlake.com/Pictionary.aspx#S" });
                    extensionSettings.AddValues(new[] { "Starboard", "http://www.sailingcanyonlake.com/Pictionary.aspx#S" });
                    extensionSettings.AddValues(new[] { "Stays", "http://www.sailingcanyonlake.com/Pictionary.aspx#S" });
                    extensionSettings.AddValues(new[] { "Stem", "http://www.sailingcanyonlake.com/Pictionary.aspx#S" });
                    extensionSettings.AddValues(new[] { "Stern", "http://www.sailingcanyonlake.com/Pictionary.aspx#S" });
                    extensionSettings.AddValues(new[] { "Tack", "http://www.sailingcanyonlake.com/Pictionary.aspx#T" });
                    extensionSettings.AddValues(new[] { "Tell tales", "http://www.sailingcanyonlake.com/Pictionary.aspx#T" });
                    extensionSettings.AddValues(new[] { "Top sail", "http://www.sailingcanyonlake.com/Pictionary.aspx#T" });
                    extensionSettings.AddValues(new[] { "Transom", "http://www.sailingcanyonlake.com/Pictionary.aspx#T" });
                    extensionSettings.AddValues(new[] { "Trim", "http://www.sailingcanyonlake.com/Pictionary.aspx#T" });
                    extensionSettings.AddValues(new[] { "Trimaran", "http://www.sailingcanyonlake.com/Pictionary.aspx#T" });
                    extensionSettings.AddValues(new[] { "True wind", "http://www.sailingcanyonlake.com/Pictionary.aspx#T" });
                    extensionSettings.AddValues(new[] { "Trunk", "http://www.sailingcanyonlake.com/Pictionary.aspx#T" });
                    extensionSettings.AddValues(new[] { "Vang", "http://www.sailingcanyonlake.com/Pictionary.aspx#V" });
                    extensionSettings.AddValues(new[] { "Wake", "http://www.sailingcanyonlake.com/Pictionary.aspx#W" });
                    extensionSettings.AddValues(new[] { "Waterline", "http://www.sailingcanyonlake.com/Pictionary.aspx#W" });
                    extensionSettings.AddValues(new[] { "Well", "http://www.sailingcanyonlake.com/Pictionary.aspx#W" });
                    extensionSettings.AddValues(new[] { "Windward", "http://www.sailingcanyonlake.com/Pictionary.aspx#W" });
                    extensionSettings.AddValues(new[] { "Work Boat", "http://www.sailingcanyonlake.com/Pictionary.aspx#W" });
                    extensionSettings.AddValues(new[] { "Yard", "http://www.sailingcanyonlake.com/Pictionary.aspx#Y" });
                    extensionSettings.AddValues(new[] { "Zephyr", "http://www.sailingcanyonlake.com/Pictionary.aspx#Z" });
                    terms = ExtensionManager.InitSettings("SailingTerms", extensionSettings);
                }
                return terms;
            }
            set
            {
                terms = value;
            }
        }
    }

}
