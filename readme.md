Description
-----------

The purpose of this short code example is to demonstrate / prove that the 
Bakery Algorithm ([Lamport][1]) does indeed satisify the requirements of 
mutual exclusion and lockout-freedom.

So far, the algorithm is able to control a group of users and obey the 
mutual exclusion requirement, as well as progress/lock-freedom lemmas.
However, one area I'm still looking for a solution is in the case where
a user process P fails while within C.

[1]: http://en.wikipedia.org/wiki/Lamport's_bakery_algorithm
