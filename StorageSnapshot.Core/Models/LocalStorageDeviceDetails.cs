﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSnapshot.Core.Models;

public class LocalStorageDeviceDetails
{
    public long TotalFiles
    {
        get;
        internal set;
    }
    public long TotalDirectories
    {
        get;
        internal set;
    }
    public Dictionary<string, MimeTypeDetails> MimeTypeDetailsDictionary { get; internal set; } = new Dictionary<string, MimeTypeDetails>();

}
