
const canvas = document.getElementById("gameCanvas");
const ctx = canvas.getContext("2d");

let car = { x: 50, y: 180, width: 50, height: 30, speed: 5 };

document.addEventListener("keydown", (e) => {
  if (e.key === "ArrowRight") car.x += car.speed;
  if (e.key === "ArrowLeft") car.x -= car.speed;
  if (e.key === "ArrowUp") car.y -= car.speed;
  if (e.key === "ArrowDown") car.y += car.speed;
});

function drawCar() {
  ctx.fillStyle = "#f1c40f";
  ctx.fillRect(car.x, car.y, car.width, car.height);
}

function clearCanvas() {
  ctx.clearRect(0, 0, canvas.width, canvas.height);
}

function gameLoop() {
  clearCanvas();
  drawCar();
  requestAnimationFrame(gameLoop);
}

gameLoop();
