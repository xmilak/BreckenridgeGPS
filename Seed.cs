using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreckenridgeGPS
{
    public static class Seed
    {
        public static List<Trail> GetAllPeak8Trails()
        {
            var Trails = new List<Trail>();


            var trail1 = new Trail()
            {
                Name = "Four O'Clock(B)",
                GetTo = "To get to Four O'Clock trail, you can take the gondola to the base of Peak 8 and then access the Colorado Superchair. " +
                "From there, start skiing down Four O'Clock trail. " +
                "This trail is named after the historic Four O'Clock Mine, which was a gold mine in the area.",
                Gondola = "Take the Four O' Clock trail all the way down until you reach the base of the gondola. " +
                "The gondola is located at the base of Peak 8.",
                Parking = "From the bottom of Four O'Clock trail, head east on Park Ave until you reach Village Rd.\r\nTurn left onto Village Rd and continue straight until you reach Ski Hill Rd.\r\nTurn right onto Ski Hill Rd and continue for about 0.2 miles.\r\nTurn left onto Park Ave and continue for about 0.1 miles until you reach the base of the Gondola Ski Back trail.",
                TrailNumber = 1
            };
            Trails.Add(trail1);

            var trail2 = new Trail()
            {
                Name = "Trygve's(G)",
                GetTo = "From the bottom of Trygve's, follow the trail signs to the gondola base area.",
                Gondola = "Take the gondola to the top of Peak 8 and access the Colorado Superchair. " +
                        "From there, start skiing down the 4 O'Clock trail, and you'll see the entrance to Trygve's trail on your right.",
                Parking = "Follow the signs for the BreckConnect gondola and take it to the base of Peak 8.\r\nOnce you reach the base of Peak 8, ski down the \"Springmeier\" trail (B) until you reach the intersection with the \"Lower 4 O'Clock\" trail.\r\nTurn right onto Lower 4 O'Clock and continue for about 0.2 miles.\r\nTurn right onto Sawmill Rd and continue for about 0.1 miles until you reach the base of the Gondola Ski Back trail.",
                TrailNumber = 2
            };
            Trails.Add(trail2);

            var trail3 = new Trail()
            {
                Name = "Lower 4 O'Clock",
                GetTo = "Take Four O'Clock Road downhill until you reach the base of the gondola.",
                Gondola = "The gondola is located at the base of Peak 8.",
                Parking = "From the bottom of Lower 4 O'Clock trail, turn right onto Sawmill Rd.\r\nContinue for about 0.1 miles until you reach the base of the Gondola Ski Back trail.",
                TrailNumber= 3
            };
            Trails.Add(trail3);

            var trail4 = new Trail()
            {
                Name = "Snowflake(B)",
                GetTo = "Follow the Snowflake trail down to Snowflake Road. Follow Snowflake Road downhill until you reach the base of the gondola.",
                Gondola = "The gondola is located at the base of Peak 8.",
                Parking = "From the bottom of Snowflake trail, head east on Four O'Clock Rd.\r\nContinue for about 0.4 miles until you reach Park Ave.\r\nTurn right onto Park Ave and continue for about 0.1 miles until you reach the base of the Gondola Ski Back trail.",
                TrailNumber = 4 
            };
            Trails.Add(trail4);

            var trail5 = new Trail()
            {
                Name = "Claimjumper(G)",
                GetTo = "Follow the Claimjumper trail down to Park Avenue. Turn right on Park Avenue and follow it downhill until you reach the base of the gondola.",
                Gondola = "Take the gondola to the top of Peak 8 and access the Colorado Superchair. " +
                        "From there, start skiing down the 4 O'Clock trail. After a short distance, look for the entrance to Claimjumper trail on your left.",
                Parking = "Follow the signs for the BreckConnect gondola and take it to the base of Peak 8.\r\nOnce you reach the base of Peak 8, ski down the \"Springmeier\" trail (B) until you reach the intersection with the \"Lower 4 O'Clock\" trail.\r\nTurn right onto Lower 4 O'Clock and continue for about 0.2 miles.\r\nTurn right onto Sawmill Rd and continue for about 0.1 miles until you reach the base of the Gondola Ski Back trail.",
                TrailNumber = 5
            };
            Trails.Add(trail5);

            var trail6 = new Trail()
            {
                Name = "Springmeier(B)",
                GetTo = "Follow the Springmeier trail down to Park Avenue. Turn right on Park Avenue and follow it downhill until you reach the base of the gondola.",
                Gondola = "Start at the Springmeier Trailhead, which is located near the intersection of Springmeier Drive and North Tenmile Drive." +
                "Follow the Springmeier Trail until you reach the intersection with the Four O'Clock Ski Run." +
                "Turn right onto the Four O'Clock Ski Run and continue down the slope until you reach the base of the Breckenridge Ski Resort.",
                Parking = "From the bottom of Springmeier trail, turn left onto Lower 4 O'Clock Rd.\r\nContinue for about 0.2 miles.\r\nTurn right onto Sawmill Rd and continue for about 0.1 miles until you reach the base of the Gondola Ski Back trail.",
                TrailNumber = 6
            };
            Trails.Add(trail6);

            var trail7 = new Trail()
            {
                Name = "Upper Sawmill(B)",
                GetTo = "Access the Colorado Superchair next to the gondola. From there, start skiing down Four O' Clock trail." +
                " Ski past the intersection with Lower 4 O' Clock trail and look for the entrance to Upper Sawmill trail on your left.",
                Gondola = "Follow the Upper Sawmill trail down to Sawmill Run Road. Turn right on Sawmill Run Road and follow it downhill until you reach the base of the gondola.",
                Parking = "From the bottom of Upper Sawmill trail, turn right onto Sawmill Rd.\r\nContinue for about 0.1 miles until you reach the base of the Gondola Ski Back trail.",
                TrailNumber = 7


            };
            Trails.Add(trail7);

            var trail8 = new Trail()
            {
                Name = "Sawmill(B)",
                GetTo = "Access the Colorado Superchair next to the gondola. From there, start skiing down Four O' Clock trail. " +
                "After you pass the intersection with Lower 4 O' Clock trail, take a left onto Upper Sawmill trail. The entrance to " +
                "Sawmill trail will be on your left shortly after.",
                Gondola = "Follow the Sawmill trail down to Sawmill Run Road. Turn right on Sawmill Run Road and follow it downhill until you reach the base of the gondola.",
                Parking = "From the bottom of Sawmill trail, turn right onto Sawmill Rd.\r\nContinue for about 0.1 miles until you reach the base of the Gondola Ski Back trail.",
                TrailNumber = 8


            };
            Trails.Add(trail8);

            var trail9 = new Trail()
            {
                Name = "Sundown(B)",
                GetTo = "Access the Colorado Superchair next to the gondola. From there, start skiing down Four O' Clock trail." +
                " After you pass the intersection with Lower 4 O' Clock trail, take a left onto Upper Sawmill trail. " +
                "Ski past the intersection with Sawmill trail and look for the entrance to Sundown trail on your left.",
                Gondola = "Follow the Sundown trail down to Four O'Clock Road. Turn left on Four O'Clock Road and follow it downhill until you reach the base of the gondola.",
                Parking = "From the bottom of Sundown trail, turn left onto Four O'Clock Rd.\r\nContinue for about 0.4 miles until you reach Park Ave.\r\nTurn right onto Park Ave and continue for about 0.1 miles until you reach the base of the Gondola Ski Back trail.",
                TrailNumber = 9

            };
            Trails.Add(trail9);

            var trail10 = new Trail()
            {
                Name = "Swinger(B)",
                GetTo = "Access the Snowflake lift from the base of Peak 8. " +
                "Ski down Snowflake trail, and the entrance to Swinger trail will be on your left.",
                Gondola = "Follow the Swinger trail down to Four O'Clock Road. Turn left on Four O'Clock Road and follow it downhill until you reach the base of the gondola.",
                Parking = "Follow Swinger Ski Run to the base of Peak 9. Cross Park Avenue and turn right onto Ski Hill Road. Follow Ski Hill Road for about 0.3 miles (or approximately 5 minutes) until you reach the gondola parking lot on your left.",
                TrailNumber = 10

            };
            Trails.Add(trail10);

            var trail11 = new Trail()
            {
                Name = "Frosty's Freeway(G)",
                GetTo = "From the top of the Colorado Superchair lift, ski down the 4 O'Clock trail. " +
                "After a short distance, look for the entrance to Frosty's Freeway trail on your left.",
                Gondola = "Follow the Frosty's Freeway trail down to Park Avenue. Turn right on Park Avenue and follow it downhill until you reach the base of the gondola.",
                Parking = "Frosty's Freeway(G): Follow the Frosty's Freeway trail until you reach the intersection with the 4 O'Clock trail. Turn right onto 4 O'Clock and follow it for about 0.6 miles until you reach the intersection with the Gondola Ski Back Trail. Turn left onto the Gondola Ski Back Trail and follow it until you reach the bottom.",
                TrailNumber = 11

            };
            Trails.Add(trail11);

            var trail12 = new Trail()
            {
                Name = "Duke's Run(B)",
                GetTo = "Take the Colorado Superchair lift to the top, and start skiing down the 4 O'Clock trail." +
                " After you pass the intersection with Lower 4 O'Clock trail, look for the entrance to Duke's Run trail on your left.",
                Gondola = "Follow the Duke's Run trail down to Four O'Clock Road. Turn left on Four O'Clock Road and follow it downhill until you reach the base of the gondola.\r\n",
                Parking = "Follow Duke's Run until you reach the intersection with the Lower 4 O'Clock trail. Turn right onto Lower 4 O'Clock and follow it for about 0.5 miles until you reach the intersection with the Gondola Ski Back Trail. Turn left onto the Gondola Ski Back Trail and follow it until you reach the bottom.",
                TrailNumber = 12


            };
            Trails.Add(trail12);

            var trail13 = new Trail()
            {
                Name = "Park Lane(B)",
                GetTo = "Access the Snowflake lift from the base of Peak 8. " +
                "Ski down Snowflake trail, and the entrance to Park Lane trail will be on your left.",
                Gondola = "Follow the Park Lane trail down to Four O'Clock Road. Turn right on Four O'Clock Road and follow it downhill until you reach the base of the gondola.",
                Parking = "Follow Park Lane until you reach the intersection with the Snowflake trail. Turn left onto Snowflake and follow it until you reach the intersection with the Gondola Ski Back Trail. Turn right onto the Gondola Ski Back Trail and follow it until you reach the bottom.",
                TrailNumber = 13

            };
            Trails.Add(trail13);

            var trail14 = new Trail()
            {
                Name = "Peerless(Bk)",
                GetTo = "Take the Colorado Superchair lift to the top, and start skiing down the 4 O'Clock trail. " +
                "After you pass the intersection with Lower 4 O'Clock trail, look for the entrance to Peerless trail on your right.",
                Gondola = "Follow the Peerless trail down to Bonanza. Turn left on Bonanza and follow it downhill until you reach the base of the gondola.",
                Parking = "Follow Peerless until you reach the intersection with the Lower 4 O'Clock trail. Turn right onto Lower 4 O'Clock and follow it for about 0.5 miles until you reach the intersection with the Gondola Ski Back Trail. Turn left onto the Gondola Ski Back Trail and follow it until you reach the bottom.",
                TrailNumber = 14

            };
            Trails.Add(trail14);

            var trail15 = new Trail()
            {
                Name = "Northstar(Bk)",
                GetTo = "Take the Colorado Superchair lift to the top, and start skiing down the 4 O'Clock trail. " +
                "After you pass the intersection with Lower 4 O'Clock trail, look for the entrance to Northstar trail on your right.",
                Gondola = "Follow the Northstar trail down to Bonanza. Turn left on Bonanza and follow it downhill until you reach the base of the gondola.\r\n",
                Parking = "Follow Northstar until you reach the intersection with the Lower 4 O'Clock trail. Turn right onto Lower 4 O'Clock and follow it for about 0.5 miles until you reach the intersection with the Gondola Ski Back Trail. Turn left onto the Gondola Ski Back Trail and follow it until you reach the bottom.",
                TrailNumber = 15

            };
            Trails.Add(trail15);

            var trail16 = new Trail()
            {
                Name = "Whale's Tail(B)",
                GetTo = "Access the Snowflake lift from the base of Peak 8. " +
                "Ski down Snowflake trail, and the entrance to Whale's Tail trail will be on your left.",
                Gondola = "Follow the Whale's Tail trail down to Four O'Clock Road.Turn left on Four O'Clock Road and follow it downhill until you reach the base of the gondola.",
                Parking = "Follow Whale's Tail until you reach the intersection with the Lower 4 O'Clock trail. Turn right onto Lower 4 O'Clock and follow it for about 0.5 miles until you reach the intersection with the Gondola Ski Back Trail. Turn left onto the Gondola Ski Back Trail and follow it until you reach the bottom.",
                TrailNumber = 16

            };
            Trails.Add(trail16);

            var trail17 = new Trail()
            {
                Name = "Silverthorne(B)",
                GetTo = "Access the Snowflake lift from the base of Peak 8. " +
                "Ski down Snowflake trail, and the entrance to Silverthorne trail will be on your right.",
                Gondola = "Follow the Silverthorne trail down to the base of the Mercury Superchair lift. Take the lift up to the top and follow the signs to the gondola base area.",
                Parking = "Follow Silverthorne until you reach the intersection with the Snowflake trail. Turn left onto Snowflake and follow it until you reach the intersection with the Gondola Ski Back Trail. Turn right onto the Gondola Ski Back Trail and follow it until you reach the bottom.",
                TrailNumber =17

            };
            Trails.Add(trail17);

            return Trails;
        }
        public static List<Trail> GetAllPeak9Trails()
        {
            var Trails = new List<Trail>();
            var trail1 = new Trail
            {
                Name = "American(B)",
                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. The American trail will be on your right.",
                Gondola = "Follow the American trail down to the intersection with the Lower Lehman trail. " +
                "Turn right onto Lower Lehman and continue downhill until you reach the base of the gondola.",
                Parking = "Ski down American to the intersection with 4 O'Clock trail, turn left onto 4 O'Clock and ski down to the base of the gondola. From there, take the \"Gondola Ski Back\" trail to the bottom.",
                TrailNumber = 1

            };
            Trails.Add(trail1);

            var trail2 = new Trail
            {
                Name = "Bonanza(B)",
                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. " +
                "This trail is one of the main runs on Peak 9 and is hard to miss.",
                Gondola = "Follow the Bonanza trail down to the intersection with the Peerless/Bonanza Connector trail. " +
                "Turn left onto the connector and continue until you reach the intersection with the Peerless trail. " +
                "Turn right onto the Peerless trail and follow it downhill until you reach the base of the gondola.",
                Parking = "Ski down Bonanza to the intersection with 4 O'Clock trail, turn left onto 4 O'Clock and ski down to the base of the gondola. From there, take the \"Gondola Ski Back\" trail to the bottom.",
                TrailNumber = 2

            };
            Trails.Add(trail2);

            var trail3 = new Trail
            {
                Name = "Cashier(G)",
                GetTo = "Access the Colorado Superchair lift next to the gondola and ride it to the top. " +
                "Follow the Cashier trail down, which is located on skier's right just before the bottom of the lift.",
                Gondola = "Follow the Cashier trail down to the intersection with the Volunteer trail. " +
                "Turn right onto Volunteer and follow it downhill until you reach the intersection with the Cucumber trail. " +
                "Turn left onto Cucumber and continue until you reach the base of the gondola.",
                Parking = "Ski down Cashier to the intersection with Trygve's trail, turn left onto Trygve's and ski down to the base of the gondola. From there, take the \"Gondola Ski Back\" trail to the bottom.",
                TrailNumber = 3
            };
            Trails.Add(trail3);

            var trail4 = new Trail
            {
                Name = "Crosscut(B)",
                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. The Crosscut trail will be on your left.",
                Gondola = "Follow the Crosscut trail down to the intersection with the Windows trail. " +
                "Turn left onto Windows and continue downhill until you reach the intersection with the Lower Lehman trail. " +
                "Turn left onto Lower Lehman and follow it downhill until you reach the base of the gondola.",
                Parking = "Ski down Crosscut to the intersection with 4 O'Clock trail, turn left onto 4 O'Clock and ski down to the base of the gondola. From there, take the \"Gondola Ski Back\" trail to the bottom.",
                TrailNumber = 4
            };
            Trails.Add(trail4);

            var trail5 = new Trail
            {
                Name = "Cucumber(G)",
                GetTo = "Access the Colorado Superchair lift next to the gondola and ride it to the top. " +
                "Follow the Cashier trail down and you'll see a sign for Cucumber on your right.",
                Gondola = "Follow the Cucumber trail down to the intersection with the Duke's trail. " +
                "Turn left onto Duke's and continue downhill until you reach the intersection with the Cashier trail. " +
                "Turn right onto Cashier and continue until you reach the base of the gondola.",
                Parking = "Ski down Cucumber to the intersection with Claimjumper trail, turn left onto Claimjumper and ski down to the base of the gondola. From there, take the \"Gondola Ski Back\" trail to the bottom.",
                TrailNumber = 5
            };
            Trails.Add(trail5);

            var trail6 = new Trail
            {
                Name = "Duke's(B)",
                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. " +
                "Duke's is a short run that branches off to the right of Bonanza.",
                Gondola = "Follow the Duke's trail down to the intersection with the Cucumber trail." +
                " Turn right onto Cucumber and continue until you reach the intersection with the Volunteer trail. " +
                "Turn left onto Volunteer and follow it downhill until you reach the intersection with the Cashier trail. " +
                "Turn left onto Cashier and continue until you reach the base of the gondola.",
                Parking = "Ski down Duke's to the intersection with 4 O'Clock trail, turn left onto 4 O'Clock and ski down to the base of the gondola. From there, take the \"Gondola Ski Back\" trail to the bottom.",
                TrailNumber = 6
            };
            Trails.Add(trail6);

            var trail7 = new Trail
            {
                Name = "Volunteer(G)",
                GetTo = "Access the Colorado Superchair lift next to the gondola and ride it to the top." +
                " Follow the Cashier trail down and keep an eye out for the Volunteer trail sign on your left.",
                Gondola = "Follow the Volunteer trail down to the intersection with the Cashier trail. " +
                "Turn right onto Cashier and continue until you reach the intersection with the Cucumber trail." +
                " Turn left onto Cucumber and continue until you reach the base of the gondola.",
                Parking = "Ski down Volunteer to the intersection with Trygve's trail, turn left onto Trygve's and ski down to the base of the gondola. From there, take the \"Gondola Ski Back\" trail to the bottom.",
                TrailNumber = 7
            };
            Trails.Add(trail7);

            var trail8 = new Trail
            {
                Name = "Wirepatch(G)",
                GetTo = "Access the Colorado Superchair lift next to the gondola and ride it to the top. " +
                "Follow the Cashier trail down and you'll see a sign for Wirepatch on your right.",
                Gondola = "Follow the Wirepatch trail down to the intersection with the Lower Lehman trail. " +
                "Turn left onto Lower Lehman and continue downhill until you reach the base of the gondola.",
                Parking = "Ski down Wirepatch to the intersection with Claimjumper trail, turn left onto Claimjumper and ski down to the base of the gondola. From there, take the \"Gondola Ski Back\" trail to the bottom.",
                TrailNumber = 8
            };
            Trails.Add(trail8);

            var trail9 = new Trail
            {
                Name = "Lower American(B)",
                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. The Lower American trail will be on your right.",
                Gondola = "Follow the Lower American trail down to the intersection with the Upper Sawmill trail. " +
                "Turn right onto Upper Sawmill and continue downhill until you reach the intersection with the Sawmill trail. " +
                "Turn right onto Sawmill and continue until you reach the base of the gondola.",
                Parking = "Ski down Lower American to the intersection with 4 O'Clock trail, turn left onto 4 O'Clock and ski down to the base of the gondola. From there, take the \"Gondola Ski Back\" trail to the bottom.",
                TrailNumber = 9
            };
            Trails.Add(trail9);

            var trail10 = new Trail
            {
                Name = "Lower Lehman(B)",
                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. " +
                "The Lower Lehman trail will be on your left, just before the base of the lift.",
                Gondola = "Follow the Lower Lehman trail down to the intersection with the Silverthorne trail. " +
                "Turn left onto Silverthorne and continue until you reach the intersection with the Peerless trail. " +
                "Turn right onto Peerless and follow it downhill until you reach the base of the gondola.",
                Parking = "Ski down Lower Lehman to the intersection with 4 O'Clock trail, turn left onto 4 O'Clock and ski down to the base of the gondola. From there, take the \"Gondola Ski Back\" trail to the bottom.",
                TrailNumber = 10
            };
            Trails.Add(trail10);

            var trail12 = new Trail
            {
                Name = "Silverthorne(B)",
                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down." +
                " The Silverthorne trail is on your left, just after the base of the lift.",
                Gondola = "Follow the Silverthorne trail down to the intersection with the Lower Lehman trail. " +
                "Turn right onto Lower Lehman and continue downhill until you reach the base of the gondola.",
                Parking = "Ski down Silverthorne to the intersection with Sawmill trail, turn right onto Sawmill and ski down to the base of the gondola. From there, take the \"Gondola Ski Back\" trail to the bottom.",
                TrailNumber = 11
            };
            Trails.Add(trail12);

            var trail13 = new Trail
            {
                Name = "Peerless(BK)",
                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down." +
                " Peerless is a short, steep run that branches off to the left of Bonanza.",
                Gondola = "Follow the Peerless trail down to the intersection with the Bonanza trail. " +
                "Turn left onto Bonanza and continue until you reach the intersection with the Peerless/Bonanza Connector trail. " +
                "Turn right onto the connector and continue until you reach the base of the gondola.",
                Parking = "Ski down Peerless to the intersection with Peerless/Bonanza Connector trail, turn left onto Peerless/Bonanza Connector and ski down to the intersection with Bonanza trail. Turn left onto Bonanza and ski down to the base of the gondola. From there, take the \"Gondola Ski Back\" trail to the bottom.",
                TrailNumber = 12
            };
            Trails.Add(trail13);

            var trail14 = new Trail
            {
                Name = "Tom's Baby(G)",
                GetTo = "Access the Colorado Superchair lift next to the gondola and ride it to the top." +
                " Follow the Cashier trail down and Tom's Baby will be on your left.",
                Gondola = "Follow the Tom's Baby trail down to the intersection with the Spruce trail. " +
                "Turn right onto Spruce and continue downhill until you reach the intersection with the Lower Lehman trail. " +
                "Turn left onto Lower Lehman and follow it downhill until you reach the base of the gondola.",
                Parking = "From the bottom of Tom's Baby, ski down the \"Lower Lehman\" trail until you reach the intersection with \"Silverthorne\" trail. Take a right onto Silverthorne and ski until you reach the \"Lower Four O'Clock\" trail. Take a left onto Lower Four O'Clock and ski until you reach the bottom of the Gondola ski back trail.",
                TrailNumber = 13
            };
            Trails.Add(trail14);

            var trail15 = new Trail
            {
                Name = "Peerless/Bonanza Connector(BK)",
                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. " +
                "The connector trail will be on your left, just after the base of the lift.",
                Gondola = "From the intersection of the Peerless and Bonanza trails, continue on the Peerless/Bonanza Connector (BK) trail. " +
                "The trail will eventually come to an end at a T-intersection with the Sawmill trail. " +
                "Turn left onto the Sawmill trail and continue downhill until you reach Sawmill Run Road. " +
                "Turn right on Sawmill Run Road and follow it downhill until you reach the base of the gondola.",
                Parking = "rom the Peerless/Bonanza Connector, ski down the \"Bonanza\" trail until you reach the intersection with \"Lower Lehman\" trail. Take a left onto Lower Lehman and ski until you reach the intersection with \"Silverthorne\" trail. Take a left onto Silverthorne and ski until you reach the \"Lower Four O'Clock\" trail. Take a left onto Lower Four O'Clock and ski until you reach the bottom of the Gondola ski back trail.",
                TrailNumber = 14
            };

            Trails.Add(trail15);

            var trail16 = new Trail
            {
                Name = "Windows(B)",
                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. " +
                "The Windows trail is on your right, just before the base of the lift.",
                Gondola = "Follow the Windows trail down to the intersection with Sawmill Run Road. " +
                "Turn right on Sawmill Run Road and follow it downhill until you reach the base of the gondola.",
                Parking = "From the Windows trail, ski down the \"Sundown\" trail until you reach the intersection with \"Lower Four O'Clock\" trail. Take a left onto Lower Four O'Clock and ski until you reach the bottom of the Gondola ski back trail.",
                TrailNumber = 15
            };
            Trails.Add(trail16);

            var trail17 = new Trail
            {
                Name = "Spruce(B)",
                GetTo = "Follow the Spruce trail down to the intersection with Sawmill Run Road. " +
                "Turn right on Sawmill Run Road and follow it downhill until you reach the base of the gondola.",
                Gondola = "Start at the Spruce Trailhead, located at the intersection of Spruce Creek Road and Blue River Road." +
                "From the trailhead, follow Spruce Creek Road eastward for about 1 mile until you reach the base of the Breckenridge Ski Resort." +
                "Once you reach the ski resort, continue following Spruce Creek Road until you reach the base of Peak 8.",
                Parking = "From the Spruce trail, ski down the \"Claimjumper\" trail until you reach the intersection with \"Lower Four O'Clock\" trail. Take a left onto Lower Four O'Clock and ski until you reach the bottom of the Gondola ski back trail.",
                TrailNumber = 16
            };
            Trails.Add(trail17);

            var trail18 = new Trail
            {
                Name = "Sawmill(B)",
                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. " +
                "The Sawmill trail is on your right, just before the base of the lift.",
                Gondola = "Follow the Sawmill trail down to the intersection with Sawmill Run Road. " +
                "Turn right on Sawmill Run Road and follow it downhill until you reach the base of the gondola.",
                Parking = "From the Sawmill trail, ski down the \"Sawmill Gulch\" trail until you reach the intersection with \"Sundown\" trail. Take a left onto Sundown and ski until you reach the intersection with \"Lower Four O'Clock\" trail. Take a left onto Lower Four O'Clock and ski until you reach the bottom of the Gondola ski back trail.",
                TrailNumber = 17

            };
            Trails.Add(trail18);

            return Trails;

        }
    }
}
