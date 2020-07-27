﻿using System.Collections.Generic;

namespace DFrame.KubernetesWorker.Models
{
    public class V1NodeSelectorRequirement
    {
        public string key { get; set; }
        public string @operator { get; set; }
        public IList<string> values { get; set; }
    }
}
