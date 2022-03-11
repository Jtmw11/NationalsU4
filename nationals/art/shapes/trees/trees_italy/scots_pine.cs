
singleton TSShapeConstructor(Scots_pineDae)
{
   baseShape = "./scots_pine.dae";
};

function Scots_pineDae::onLoad(%this)
{
   %this.addImposter("25", "8", "0", "0", "256", "1", "0");
}
