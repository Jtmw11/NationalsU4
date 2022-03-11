
singleton TSShapeConstructor(Scots_pineDae)
{
   baseShape = "./scots_pine.dae";
};

function Scots_pineDae::onLoad(%this)
{
   %this.addImposter("25", "8", "0", "0", "128", "1", "0");
}

singleton TSShapeConstructor(Maritime_pineDae)
{
   baseShape = "./maritime_pine.dae";
};

function Maritime_pineDae::onLoad(%this)
{
   %this.addImposter("25", "8", "0", "0", "128", "1", "0");
}
