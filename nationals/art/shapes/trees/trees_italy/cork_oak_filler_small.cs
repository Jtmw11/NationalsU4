
singleton TSShapeConstructor(Cork_oak_filler_smallDae)
{
   baseShape = "./cork_oak_filler_small.dae";
};

function Cork_oak_filler_smallDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "0", "0");
}
