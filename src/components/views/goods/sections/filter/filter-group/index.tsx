import { FC, useRef } from "react";
import { Form } from "../../../../../base/form";

interface Props {
   label: string;
   options: Array<{ name: string; value: string; }>;
   onChange: (values: { [key: string]: any }) => void;
}

export const FilterGroup: FC<Props> = ({ label, options, onChange }) => {

   const handleCheck = () => {
      ref.current?.requestSubmit();
   }

   const handleFinish = (values: { [key: string]: any }) => {
      onChange(values);
   }

   const ref = useRef<HTMLFormElement>(null);

   return (
      <div className="border p-4">
         <span className="text-sm font-medium">{label}</span>
         <Form onFinish={handleFinish} ref={ref}>
            <ul>
               {options.map((option, index) => (
                  <li key={index} className="mt-2">
                     <label className="flex items-center">
                        <input onChange={handleCheck} name={option.value} className="w-4 h-4" type="checkbox" />
                        <span className="ml-2">{option.name}</span>
                     </label>
                  </li>
               ))}
            </ul>
         </Form>
      </div>
   );
} 