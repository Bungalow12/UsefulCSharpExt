# UsefulCSharpExt
Useful C# Class Extensions

In the initial version I introduced string extensions to allow for the static Format call on a string instance:
"Standard Format Example: Hex: 0x{0:X8}".Format(110);

And a Python style named argument version:
[0x{location:X8}] {function}({type} bar)".Format(new Dictionary<string, object>()
                {
                    {"function", "Foo"},
                    {"type", "int"},
                    {"location", 110}
                });
                
As you can see the formatting options still apply from the standard Format call.

In order to make this all happen there is a Replace method added to the a string instance that allows for the 
replacing of the value in a RegEx Group name.

I can't take credit for that code as I found it randomly online at some point and cannot seem to find the 
stack overflow link again. So thanks anonymous author!
