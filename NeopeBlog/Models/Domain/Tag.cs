using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System;
using Microsoft.AspNetCore.Identity;

namespace Blog.Models.Domain
{
    public class Tag 
    {
        // Additional properties specific to your user
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string DisplayedName { get; set; }


        public ICollection<BlogPost> BlogPosts { get; set; }

    }



}
