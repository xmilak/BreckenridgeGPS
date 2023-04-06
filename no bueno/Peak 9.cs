//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BreckenridgeGPS
//{
//    public static class Peak_9
//    {
//        public static string Name { get; set; }
//        public static List<Trail> Trails { get; set; } = new List<Trail>();

//        public static void GetAllTrails()
//        {
//            var Trails = new List<Trail>();

//            var trail1 = new Trail
//            {
//                Name = "American(B)",
//                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. The American trail will be on your right.",
//                Gondola = "Follow the American trail down to the intersection with the Lower Lehman trail. " +
//                "Turn right onto Lower Lehman and continue downhill until you reach the base of the gondola.",

//            };
//            Trails.Add(trail1);

//            var trail2 = new Trail
//            {
//                Name = "Bonanza(B)",
//                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. " +
//                "This trail is one of the main runs on Peak 9 and is hard to miss.",
//                Gondola = "Follow the Bonanza trail down to the intersection with the Peerless/Bonanza Connector trail. " +
//                "Turn left onto the connector and continue until you reach the intersection with the Peerless trail. " +
//                "Turn right onto the Peerless trail and follow it downhill until you reach the base of the gondola."

//            };
//            Trails.Add(trail2);

//            var trail3 = new Trail
//            {
//                Name = "Cashier(G)",
//                GetTo = "Access the Colorado Superchair lift next to the gondola and ride it to the top. " +
//                "Follow the Cashier trail down, which is located on skier's right just before the bottom of the lift.",
//                Gondola = "Follow the Cashier trail down to the intersection with the Volunteer trail. " +
//                "Turn right onto Volunteer and follow it downhill until you reach the intersection with the Cucumber trail. " +
//                "Turn left onto Cucumber and continue until you reach the base of the gondola."
//            };
//            Trails.Add(trail3);

//            var trail4 = new Trail
//            {
//                Name = "Crosscut(B)",
//                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. The Crosscut trail will be on your left.",
//                Gondola = "Follow the Crosscut trail down to the intersection with the Windows trail. " +
//                "Turn left onto Windows and continue downhill until you reach the intersection with the Lower Lehman trail. " +
//                "Turn left onto Lower Lehman and follow it downhill until you reach the base of the gondola."
//            };
//            Trails.Add(trail4);

//            var trail5 = new Trail
//            {
//                Name = "Cucumber(G)",
//                GetTo = "Access the Colorado Superchair lift next to the gondola and ride it to the top. " +
//                "Follow the Cashier trail down and you'll see a sign for Cucumber on your right.",
//                Gondola = "Follow the Cucumber trail down to the intersection with the Duke's trail. " +
//                "Turn left onto Duke's and continue downhill until you reach the intersection with the Cashier trail. " +
//                "Turn right onto Cashier and continue until you reach the base of the gondola."
//            };
//            Trails.Add(trail5);

//            var trail6 = new Trail
//            {
//                Name = "Duke's(B)",
//                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. " +
//                "Duke's is a short run that branches off to the right of Bonanza.",
//                Gondola = "Follow the Duke's trail down to the intersection with the Cucumber trail." +
//                " Turn right onto Cucumber and continue until you reach the intersection with the Volunteer trail. " +
//                "Turn left onto Volunteer and follow it downhill until you reach the intersection with the Cashier trail. " +
//                "Turn left onto Cashier and continue until you reach the base of the gondola."
//            };
//            Trails.Add(trail6);

//            var trail7 = new Trail
//            {
//                Name = "Volunteer(G)",
//                GetTo = "Access the Colorado Superchair lift next to the gondola and ride it to the top." +
//                " Follow the Cashier trail down and keep an eye out for the Volunteer trail sign on your left.",
//                Gondola = "Follow the Volunteer trail down to the intersection with the Cashier trail. " +
//                "Turn right onto Cashier and continue until you reach the intersection with the Cucumber trail." +
//                " Turn left onto Cucumber and continue until you reach the base of the gondola."
//            };
//            Trails.Add(trail7);

//            var trail8 = new Trail
//            {
//                Name = "Wirepatch(G)",
//                GetTo = "Access the Colorado Superchair lift next to the gondola and ride it to the top. " +
//                "Follow the Cashier trail down and you'll see a sign for Wirepatch on your right.",
//                Gondola = "Follow the Wirepatch trail down to the intersection with the Lower Lehman trail. " +
//                "Turn left onto Lower Lehman and continue downhill until you reach the base of the gondola."
//            };
//            Trails.Add(trail8);

//            var trail9 = new Trail
//            {
//                Name = "Lower American(B)",
//                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. The Lower American trail will be on your right.",
//                Gondola = "Follow the Lower American trail down to the intersection with the Upper Sawmill trail. " +
//                "Turn right onto Upper Sawmill and continue downhill until you reach the intersection with the Sawmill trail. " +
//                "Turn right onto Sawmill and continue until you reach the base of the gondola."
//            };
//            Trails.Add(trail9);

//            var trail10 = new Trail
//            {
//                Name = "Lower Lehman(B)",
//                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. " +
//                "The Lower Lehman trail will be on your left, just before the base of the lift.",
//                Gondola = "Follow the Lower Lehman trail down to the intersection with the Silverthorne trail. " +
//                "Turn left onto Silverthorne and continue until you reach the intersection with the Peerless trail. " +
//                "Turn right onto Peerless and follow it downhill until you reach the base of the gondola."
//            };
//            Trails.Add(trail10);

//            var trail12 = new Trail
//            {
//                Name = "Silverthorne(B)",
//                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down." +
//                " The Silverthorne trail is on your left, just after the base of the lift.",
//                Gondola = "Follow the Silverthorne trail down to the intersection with the Lower Lehman trail. " +
//                "Turn right onto Lower Lehman and continue downhill until you reach the base of the gondola."
//            };
//            Trails.Add(trail12);

//            var trail13 = new Trail 
//            { 
//                Name = "Peerless(BK)" ,
//                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down." +
//                " Peerless is a short, steep run that branches off to the left of Bonanza.",
//                Gondola = "Follow the Peerless trail down to the intersection with the Bonanza trail. " +
//                "Turn left onto Bonanza and continue until you reach the intersection with the Peerless/Bonanza Connector trail. " +
//                "Turn right onto the connector and continue until you reach the base of the gondola."
//            };
//            Trails.Add(trail13);

//            var trail14 = new Trail { Name = "Tom's Baby(G)", 
//                GetTo = "Access the Colorado Superchair lift next to the gondola and ride it to the top." +
//                " Follow the Cashier trail down and Tom's Baby will be on your left.",
//                Gondola = "Follow the Tom's Baby trail down to the intersection with the Spruce trail. " +
//                "Turn right onto Spruce and continue downhill until you reach the intersection with the Lower Lehman trail. " +
//                "Turn left onto Lower Lehman and follow it downhill until you reach the base of the gondola."
//            };
//        Trails.Add(trail14);

//            var trail15 = new Trail 
//            { 
//                Name = "Peerless/Bonanza Connector(BK)" ,
//                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. " +
//                "The connector trail will be on your left, just after the base of the lift.",
//                Gondola = "From the intersection of the Peerless and Bonanza trails, continue on the Peerless/Bonanza Connector (BK) trail. " +
//                "The trail will eventually come to an end at a T-intersection with the Sawmill trail. " +
//                "Turn left onto the Sawmill trail and continue downhill until you reach Sawmill Run Road. " +
//                "Turn right on Sawmill Run Road and follow it downhill until you reach the base of the gondola."
//            };

//            Trails.Add(trail15);

//            var trail16 = new Trail 
//            {
//                Name = "Windows(B)" ,
//                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. " +
//                "The Windows trail is on your right, just before the base of the lift.",
//                Gondola = "Follow the Windows trail down to the intersection with Sawmill Run Road. " +
//                "Turn right on Sawmill Run Road and follow it downhill until you reach the base of the gondola."
//            };
//            Trails.Add(trail16);

//            var trail17 = new Trail 
//            { 
//                Name = "Spruce(B)" ,
//                GetTo = "Follow the Spruce trail down to the intersection with Sawmill Run Road. " +
//                "Turn right on Sawmill Run Road and follow it downhill until you reach the base of the gondola.",
//                Gondola = ""
//            };
//            Trails.Add(trail17);

//            var trail18 = new Trail 
//            {
//                Name = "Sawmill(B)",
//                GetTo = "Take the Mercury Superchair lift and follow the Bonanza trail down. " +
//                "The Sawmill trail is on your right, just before the base of the lift.",
//                Gondola = "Follow the Sawmill trail down to the intersection with Sawmill Run Road. " +
//                "Turn right on Sawmill Run Road and follow it downhill until you reach the base of the gondola."

//            };
//            Trails.Add(trail18);

//            foreach (var thing in Trails)
//            {
//                Console.WriteLine(thing.Name);
//            }
//        }

//    }

//}
