import { FC } from "react";

const pictures = [
   '/preview.jpeg',
   '/preview.jpeg',
   '/preview.jpeg',
   '/preview.jpeg',
];

export const Gallery: FC = () => {
   return (
      <div className="grid grid-cols-[65%_35%] shadow">
         <div className="mr-1">
            <img className="w-full h-[360px] object-cover" src={pictures[0]} />
            <div className="grid grid-cols-2 mt-1 gap-x-1">
               <img className="w-full h-[360px] object-cover" src={pictures[1]} />
               <img className="w-full h-[360px] object-cover" src={pictures[2]} />
            </div>
         </div>
         <img className="w-full h-[724px] object-cover" src={pictures[3]} />
      </div>
   );
};