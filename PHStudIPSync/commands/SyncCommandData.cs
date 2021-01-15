namespace PHStudIPSync
{
    class SyncCommandData
    {
        public SyncCommandUser user;
        public string base_url = "https://lms.ph-karlsruhe.de/studip/index.php?again=yes";
        public string auth_type = "general";
        public string files_destination;
        public string media_destination;
    }
}
