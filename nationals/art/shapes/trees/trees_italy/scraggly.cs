
singleton TSShapeConstructor(ScragglyDae)
{
   baseShape = "./scraggly.dae";
};

function ScragglyDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "1", "0");
}
