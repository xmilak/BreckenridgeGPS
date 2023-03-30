using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace BreckenridgeGPS
{
    public static class Peak_8
    {
        public static string Name { get; set; }
        public static string GetTo { get; set; }
        public static List<Trail> Trails { get; set; } = new List<Trail>();

        public static void GetAllTrails()
        {


            var trail1 = new Trail()
            {
                Name = "Four O'Clock(B)",
                GetTo = "To get to Four O'Clock trail, you can take the gondola to the base of Peak 8 and then access the Colorado Superchair. " +
                "From there, start skiing down Four O'Clock trail. " +
                "This trail is named after the historic Four O'Clock Mine, which was a gold mine in the area.",
                Gondola = "Take the Four O' Clock trail all the way down until you reach the base of the gondola. " +
                "The gondola is located at the base of Peak 8."
            };
            Trails.Add(trail1);

            var trail2 = new Trail()
            {
                Name = "Trygve's(G)",
                GetTo = "From the bottom of Trygve's, follow the trail signs to the gondola base area.",
                Gondola = "Take the gondola to the top of Peak 8 and access the Colorado Superchair. " +
                        "From there, start skiing down the 4 O'Clock trail, and you'll see the entrance to Trygve's trail on your right."
            };
            Trails.Add(trail2);

            var trail3 = new Trail()
            {
                Name = "Lower 4 O'Clock",
                GetTo = "Take Four O'Clock Road downhill until you reach the base of the gondola.",
                Gondola = "The gondola is located at the base of Peak 8."
            };
            Trails.Add(trail3);

            var trail4 = new Trail()
            {
                Name = "Snowflake(B)",
                GetTo = "Follow the Snowflake trail down to Snowflake Road. Follow Snowflake Road downhill until you reach the base of the gondola.",
                Gondola = "The gondola is located at the base of Peak 8."
            };
            Trails.Add(trail4);

            var trail5 = new Trail()
            {
                Name = "Claimjumper(G)",
                GetTo = "Follow the Claimjumper trail down to Park Avenue. Turn right on Park Avenue and follow it downhill until you reach the base of the gondola.",
                Gondola = "Take the gondola to the top of Peak 8 and access the Colorado Superchair. " +
                        "From there, start skiing down the 4 O'Clock trail. After a short distance, look for the entrance to Claimjumper trail on your left."
            };
            Trails.Add(trail5);

            var trail6 = new Trail()
            {
                Name = "Springmeier(B)",
                GetTo = "Follow the Springmeier trail down to Park Avenue. Turn right on Park Avenue and follow it downhill until you reach the base of the gondola.",
                Gondola = "The gondola is located at the base of Peak 8."
            };
            Trails.Add(trail6);

            var trail7 = new Trail() 
            {
                Name = "Upper Sawmill(B)" ,
                GetTo = "Access the Colorado Superchair next to the gondola. From there, start skiing down Four O' Clock trail." +
                " Ski past the intersection with Lower 4 O' Clock trail and look for the entrance to Upper Sawmill trail on your left.",
                Gondola = "Follow the Upper Sawmill trail down to Sawmill Run Road. Turn right on Sawmill Run Road and follow it downhill until you reach the base of the gondola."


            };
            Trails.Add(trail7);

            var trail8 = new Trail() 
            {
                Name = "Sawmill(B)",
                GetTo = "Access the Colorado Superchair next to the gondola. From there, start skiing down Four O' Clock trail. " +
                "After you pass the intersection with Lower 4 O' Clock trail, take a left onto Upper Sawmill trail. The entrance to " +
                "Sawmill trail will be on your left shortly after.",
                Gondola = "Follow the Sawmill trail down to Sawmill Run Road. Turn right on Sawmill Run Road and follow it downhill until you reach the base of the gondola."


            };
            Trails.Add(trail8);

            var trail9 = new Trail() 
            {
                Name = "Sundown(B)" ,
                GetTo = "Access the Colorado Superchair next to the gondola. From there, start skiing down Four O' Clock trail." +
                " After you pass the intersection with Lower 4 O' Clock trail, take a left onto Upper Sawmill trail. " +
                "Ski past the intersection with Sawmill trail and look for the entrance to Sundown trail on your left.",
                Gondola = "Follow the Sundown trail down to Four O'Clock Road. Turn left on Four O'Clock Road and follow it downhill until you reach the base of the gondola.\r\n"

            };
            Trails.Add(trail9);

            var trail10 = new Trail() 
            {
                Name = "Swinger(B)",
                GetTo = "Access the Snowflake lift from the base of Peak 8. " +
                "Ski down Snowflake trail, and the entrance to Swinger trail will be on your left.",
                Gondola = "Follow the Swinger trail down to Four O'Clock Road. Turn left on Four O'Clock Road and follow it downhill until you reach the base of the gondola.\r\n"

            };
            Trails.Add(trail10);

            var trail11 = new Trail() 
            {
                Name = "Frosty's Freeway(G)" ,
                GetTo = "From the top of the Colorado Superchair lift, ski down the 4 O'Clock trail. " +
                "After a short distance, look for the entrance to Frosty's Freeway trail on your left.",
                Gondola = "Follow the Frosty's Freeway trail down to Park Avenue. Turn right on Park Avenue and follow it downhill until you reach the base of the gondola."

            };
            Trails.Add(trail11);

            var trail12 = new Trail() 
            {
                Name = "Duke's Run(B)" ,
                GetTo = "Take the Colorado Superchair lift to the top, and start skiing down the 4 O'Clock trail." +
                " After you pass the intersection with Lower 4 O'Clock trail, look for the entrance to Duke's Run trail on your left.",
                Gondola = "Follow the Duke's Run trail down to Four O'Clock Road. Turn left on Four O'Clock Road and follow it downhill until you reach the base of the gondola.\r\n"


            };
            Trails.Add(trail12);

            var trail13 = new Trail() 
            {
                Name = "Park Lane(B)" ,
                GetTo = "Access the Snowflake lift from the base of Peak 8. " +
                "Ski down Snowflake trail, and the entrance to Park Lane trail will be on your left.",
                Gondola = "Follow the Park Lane trail down to Four O'Clock Road. Turn right on Four O'Clock Road and follow it downhill until you reach the base of the gondola."

            };
            Trails.Add(trail13);

            var trail14 = new Trail() 
            {
                Name = "Peerless(Bk)",
                GetTo = "Take the Colorado Superchair lift to the top, and start skiing down the 4 O'Clock trail. " +
                "After you pass the intersection with Lower 4 O'Clock trail, look for the entrance to Peerless trail on your right.",
                Gondola = "Follow the Peerless trail down to Bonanza. Turn left on Bonanza and follow it downhill until you reach the base of the gondola."

            };
            Trails.Add(trail14);

            var trail15 = new Trail() 
            {
                Name = "Northstar(Bk)" ,
                GetTo = "Take the Colorado Superchair lift to the top, and start skiing down the 4 O'Clock trail. " +
                "After you pass the intersection with Lower 4 O'Clock trail, look for the entrance to Northstar trail on your right.",
                Gondola = "Follow the Northstar trail down to Bonanza. Turn left on Bonanza and follow it downhill until you reach the base of the gondola.\r\n"

            };
            Trails.Add(trail15);

            var trail16 = new Trail() 
            {
                Name = "Whale's Tail(B)", 
                GetTo = "Access the Snowflake lift from the base of Peak 8. " +
                "Ski down Snowflake trail, and the entrance to Whale's Tail trail will be on your left.",
                Gondola = "Follow the Whale's Tail trail down to Four O'Clock Road.Turn left on Four O'Clock Road and follow it downhill until you reach the base of the gondola."

            };
            Trails.Add(trail16);

            var trail17 = new Trail() 
            {
                Name = "Silverthorne(B)" ,
                GetTo = "Access the Snowflake lift from the base of Peak 8. " +
                "Ski down Snowflake trail, and the entrance to Silverthorne trail will be on your right.",
                Gondola = "Follow the Silverthorne trail down to the base of the Mercury Superchair lift. Take the lift up to the top and follow the signs to the gondola base area."

            };
            Trails.Add(trail17);

            foreach (var thing in Trails)
            {
                Console.WriteLine(thing.Name);
            }
        }
    }





}
