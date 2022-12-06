
function SetPoint(canvas, x, y){
  canvas.beginPath();
  canvas.moveTo(x-2.5, y-2.5);
  canvas.lineTo(x+2.5, y+2.5);
  canvas.stroke();
}

function SetLine(canvas, Start_x, Start_y, End_x, End_y){
  canvas.beginPath();
	canvas.moveTo(Start_x, End_x); 
	// you can actually just have a bunch of lineTo's here 
	canvas.lineTo(End_x, End_y);
	canvas.stroke();
}

function Make_route(canvas, Route){
	/* Should also change the color of the route here  */
	canvas.beginPath();
	canvas.moveTo(0, 0);
	/*For Hold in route: */
    /* SetPoint(canvas, hold_loc_x, hold_loc_y)  */
    /*   Save loc_x, and loc_y for every step of loop past 1st one */
    /* SetLine(canvas, prev_loc_x, prev_loc_y, hold_loc_x, hold_loc_y)  */
}

function getResolution() {
	alert("Your screen resolution is: " + window.screen.width * window.devicePixelRatio +
		"x" + window.screen.height * window.devicePixelRatio);
}

window.addEventListener("resize", function () {
	var c = document.getElementById("myCanvas");
	var ctx = c.getContext("2d");
	ctx.canvas.width = window.innerWidth;
	ctx.canvas.height = window.innerHeight
});
/* Before Doing ANYTHING else*/

/* For x holds :
		create moseover element at hold x
    load assocciated route into mousover location
*/



var c=document.getElementById("myCanvas");
var ctx=c.getContext("2d");
ctx.canvas.width  = window.innerWidth;
ctx.canvas.height = window.innerHeight
	/*
	 * var image = new Image();
	 * image.src = '/assets/rock_1.jpg';
	 * ctx.drawImage(image, 0, 0, ctx.canvas.width, ctx.canvas.height);
	 */


ctx.beginPath(); 
ctx.lineWidth="2";
ctx.strokeStyle="red"; 

/* This is the setup that needs to be done on mouseover */

/* need to draw each step of route being locations between holds */

/* routes have to be ordered in some way */

/* Section- X , Section-Y, Order in spot-list */

/* 1 Step in the route is then */


ctx.moveTo(75, 160);
ctx.lineTo(750, 160);
ctx.stroke();

SetPoint(ctx, 40, 600);
SetPoint(ctx, 75, 495);
SetPoint(ctx, 65, 415);
SetPoint(ctx, 112, 327);
SetPoint(ctx, 112, 250);
SetPoint(ctx, 80, 240);
SetPoint(ctx, 75, 166);
// this literally changes on the size of a browser window I cannot.