﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APIClient.Model
{
    public class ListFileResult
    {
        public int errno { get; set; }
        public string guid_info { get; set; }
        public Item[] list { get; set; }
        public long request_id { get; set; }
        public int guid { get; set; }
    }
    public class Item
    {
        public int category { get; set; }
        public int unlist { get; set; }
        public long fs_id { get; set; }
        public int oper_id { get; set; }
        public int server_ctime { get; set; }
        public int isdir { get; set; }
        public int local_mtime { get; set; }
        public long size { get; set; }
        public string server_filename { get; set; }
        public string path { get; set; }
        public int local_ctime { get; set; }
        public int server_mtime { get; set; }
        public string md5 { get; set; }
    }

}
