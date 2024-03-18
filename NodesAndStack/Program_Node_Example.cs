// Create the nodes without a next reference
Node<string> michael = new("michael", null);
Node<string> erik = new("erik", null);
Node<string> gus = new("gus", null);

//  Now let's hook the nodes with their next references
//  michael refers to erik
//  erik refers to gus
//  gus refers to ....
michael.Next = erik;
erik.Next = gus;
// gus.Next = null; // <<< this is not needed since in line 4 is already null for Next

// this will display from michael all the way to gus's next which is null
Console.WriteLine(michael);

// this will display from erik all the way to gus's next which is null, ignoring michael
Console.WriteLine(erik);

// this will display from gus all the way to gus's next which is null, ignoring michael, and erik
Console.WriteLine(gus);