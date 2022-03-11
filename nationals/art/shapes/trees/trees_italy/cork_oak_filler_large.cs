
singleton TSShapeConstructor(Cork_oak_filler_largeDae)
{
   baseShape = "./cork_oak_filler_large.dae";
};

function Cork_oak_filler_largeDae::onLoad(%this)
{
   %this.addImposter("25", "8", "0", "0", "256", "0", "0");
}
