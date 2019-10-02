/* a flexible box model */
/* the old model used box but the new model uses flex and doesn't require to use the webkit extension */
/* also, be careful with flex-flow because it can affect how the website is displayed */

*{
	margin: 0px;
	padding: 0px;
}

h1{font: bold 20px tahoma;}

h2{font: bold 14px tahoma;}

header, section, footer, aside, nav, article, hgroup{display: block;}

body{
	width: 100%; /* adjusts the body according to the size of the website window */
	display: flex;
	justify-content: center;
	border: 1px;
}

#template{
	max-width: 1000px;
	margin: 20px 0px;
	display: flex;
	flex-flow: column wrap; /* separate the elements vertically */
	flex-grow: 1; /* 1 means flexible and 0 means fixed */
}

#tophdr{
	background: yellow;
	border: 3px solid black;
	padding: 20px;
}

#topnv{
	border: red;
	background: blue;
	color: white;
}

#topnv li{
	display: inline-block; /* displays elements along one line */
	list-style: none;
	padding: 5px;
	font: bold 14px tahoma;
}

#newdiv{
	display: flex;
	flex-flow: row;
}

#mainstuff{
	border: 1px solid blue;
	flex-grow: 1;
	margin: 20px;
	padding: 20px;
}

#sidekick{
	border: 1px solid green;
	width: 200px;
	margin: 20px 0px;
	padding: 30px;
	background: #66CCCC;
}

#foot{
	text-align: center;
	padding: 20px;
	border: 2px solid green;
}

article{
	background: #FFFBCC;
	border: 1px solid red;
	padding: 20px;
	margin: 20px 0px;
}

article > footer{text-align: right;}
