
singleton TSShapeConstructor(Scots_pine_fillerDae)
{
   baseShape = "./scots_pine_filler.dae";
};

function Scots_pine_fillerDae::onLoad(%this)
{
   %this.addImposter("25", "8", "0", "0", "128", "1", "0");
}
