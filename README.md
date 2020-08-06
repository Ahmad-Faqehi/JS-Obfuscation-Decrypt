# JS-Obfuscation-Decrypt
In JS there is a way to Obfuscation the html tags and text by using Obfuscate. Here I do some programs in java and C# to decrption the code.

Maybe you see some code like this :

##The Code of Obfuscation :

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

here I write C# and Java codes to do decript the Obfuscation.

