import { FC, ReactNode, useState } from "react";

type Item = { name: string; value: any; prefix?: ReactNode };

interface Props {
   name: string;
   options: Array<Item>;
}

export const HorizontalSelect: FC<Props> = ({ name, options }) => {

   const [current, setCurrent] = useState<Item>();

   const handleClick = (index: number) => {
      setCurrent(options[index]);
   };

   return (
      <div className="flex gap-x-4">
         <input type="hidden" name={name} value={current?.value || ""} />
         {options.map((option, index) => (
            <div
               onClick={() => handleClick(index)}
               key={index}
               className={`border rounded-md px-2 py-0.5 flex space-x-2 items-center cursor-pointer hover:bg-gray-50
                  ${current?.name === option.name && 'ring ring-gray-100'}
               `}
            >
               {option.prefix}
               <span className="text-sm">{option.name}</span>
            </div>
         ))}
      </div>
   );
}