﻿using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.TestEntities
{
    class Bitrix24Task
    {
        public Bitrix24Task(string title)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }

        public string Title { get; set; }
        public string Description { get; set; }
    }
    class Bitrix24Folder
    {
        public Bitrix24Folder(string title)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }

        public string Title { get; set; }
    }
}
