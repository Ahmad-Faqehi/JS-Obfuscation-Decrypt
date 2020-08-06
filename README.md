# JS-Obfuscation-Decrypt
In JS there is a way to Obfuscation the html tags and text by using Obfuscate. Here I do some programs in **C#** to decrption the code.

Maybe you see some code like this :
##

var erp = new Array;

erp[0] = 1466264675;

erp[1] = 1869440288;

erp[2] = 1953439853;

erp[3] = 2032161641;

erp[4] = 1952779530;

erp[5] = 1013461310;

var em = '';

for(i=0;i<erp.length;i++){

tmp = erp[i];

if(Math.floor((tmp/Math.pow(256,3)))>0){
em += String.fromCharCode(Math.floor((tmp/Math.pow(256,3))));
};
tmp = tmp - (Math.floor((tmp/Math.pow(256,3))) * Math.pow(256,3));
if(Math.floor((tmp/Math.pow(256,2)))>0){
em += String.fromCharCode(Math.floor((tmp/Math.pow(256,2))));
};
tmp = tmp - (Math.floor((tmp/Math.pow(256,2))) * Math.pow(256,2));
if(Math.floor((tmp/Math.pow(256,1)))>0){
em += String.fromCharCode(Math.floor((tmp/Math.pow(256,1))));
};
tmp = tmp - (Math.floor((tmp/Math.pow(256,1))) * Math.pow(256,1));
if(Math.floor((tmp/Math.pow(256,0)))>0){
em += String.fromCharCode(Math.floor((tmp/Math.pow(256,0))));
};
	
};

document.write(em);

##
And you asking how can decripted this code.

to do decript the Obfuscation open  With [Program.cs](https://github.com/Ahmad-Faqehi/JS-Obfuscation-Decrypt/blob/master/Program.cs) file and copy the all Source code.
After that you have to replace the arrays, delete  the all arrays start from comment **// Delete This Arrays and Write Yours.**
after that pest the arrays you want to decrypted.
Now execute the program, you can use online compiler for C#, I recommend **onlinegdb** website for compile the code, You can visit the site from [here](https://www.onlinegdb.com/online_csharp_compiler)
## 


*Some pictures:

![enter image description here](https://raw.githubusercontent.com/Ahmad-Faqehi/JS-Obfuscation-Decrypt/master/Screenshot/Csharp-1.png)

**Enter Size of array:** the size is the last location in array
![enter image description here](https://raw.githubusercontent.com/Ahmad-Faqehi/JS-Obfuscation-Decrypt/master/Screenshot/Csharp-2.png)

**Click Enter**
![enter image description here](https://raw.githubusercontent.com/Ahmad-Faqehi/JS-Obfuscation-Decrypt/master/Screenshot/Csharp-3.png)

This the result the tags and is plain text :)

##

# Whatch this vedio 


[<img src="https://img.youtube.com/vi/xTBMPzyKcUI/maxresdefault.jpg" width="50%">](https://youtu.be/xTBMPzyKcUI)

